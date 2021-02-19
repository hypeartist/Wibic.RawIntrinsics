using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Intrinsics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RawIntrinsicsGenerator
{
	public static class Generator
	{
		private const string SriDataUrl1 = @"https://raw.githubusercontent.com/dotnet/runtime/master/src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/X86/";
		private const string SriDataUrl2 = @"https://raw.githubusercontent.com/dotnet/runtime/master/src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/";
		private const string IntelDataUrl = @"https://software.intel.com/sites/landingpage/IntrinsicsGuide/files/data-latest.xml";
		
		private static readonly Regex IntelMethodSignature = new(@"///\s+?(?<rt>[\w_]+)\s+?(?<fn>_mm[\w_]+)\s*?\((?<a>[\w\s,*]+)\)", RegexOptions.Compiled);
		private static readonly Regex IntelMethodSignatureSimpilfied = new(@"\s+?(?<rt>[\w_]+)\s+?(?<fn>_mm[\w_]+)\s*?", RegexOptions.Compiled);
		private static readonly Regex IntelTypeDef = new(@"(?:(?<is_unsigned>unsigned)\s+?)?(?:const\s+)?(?<type_name>void|char|short|int|long|long\s+?long|float|double|__int32|__int64|(?:(?:__m64|__m128|__m256)(?:i|d)?)|__mmask8|__mmask16|__mmask32|__mmask64)[^*""]*(?<is_ptr>\*)?", RegexOptions.Compiled);

		private static readonly Dictionary<string, (string srcUrl, Regex matcher)> TechnologyMap = new()
		{
			{"Sse", (SriDataUrl1, IntelMethodSignature)},
			{"Sse2", (SriDataUrl1, IntelMethodSignature)},
			{"Sse3", (SriDataUrl1, IntelMethodSignature)},
			{"Sse41", (SriDataUrl1, IntelMethodSignature)},
			{"Sse42", (SriDataUrl1, IntelMethodSignature)},
			{"Ssse3", (SriDataUrl1, IntelMethodSignature)},
			{"Avx", (SriDataUrl1, IntelMethodSignature)},
			{"Avx2", (SriDataUrl1, IntelMethodSignature)},
			{"Fma", (SriDataUrl1, IntelMethodSignature)},
			{"Aes", (SriDataUrl1, IntelMethodSignature)},
			{"Bmi1", (SriDataUrl1, IntelMethodSignature)},
			{"Bmi2", (SriDataUrl1, IntelMethodSignature)},
			{"Lzcnt", (SriDataUrl1, IntelMethodSignature)},
			{"Popcnt", (SriDataUrl1, IntelMethodSignature)},
			{"Pclmulqdq", (SriDataUrl1, IntelMethodSignature)},
			{"Vector64", (SriDataUrl2, IntelMethodSignatureSimpilfied)},
			{"Vector128", (SriDataUrl2, IntelMethodSignatureSimpilfied)},
			{"Vector256", (SriDataUrl2, IntelMethodSignatureSimpilfied)},
		};

		public static async Task Generate(string ns, string saveToPath)
		{
			var intelDataFile = await FetchFileContent(IntelDataUrl);

			var xml = new XmlDocument(); 
			xml.LoadXml(intelDataFile);
			var intelData = new ConcurrentBag<XmlNode>(xml.SelectNodes(@"//intrinsic")?.Cast<XmlNode>().ToList() ?? new List<XmlNode>());

			var outputData = new ConcurrentDictionary<string, ConcurrentDictionary<string, string>>();

			foreach (var kv in TechnologyMap)
			{
				await Generate($"{kv.Value.srcUrl}{kv.Key}.cs", kv.Value.matcher, intelData, outputData);
			}

			if (Directory.Exists(saveToPath))
			{
				foreach(var fi in new DirectoryInfo(saveToPath).GetFiles())
				{
					fi.Delete();
				}
				Directory.Delete(saveToPath);
			}
			Directory.CreateDirectory(saveToPath);
			
			var codeGenSb = new StringBuilder();
			string tabOffset;
			foreach (var (tech, generatedSrc) in outputData)
			{
				codeGenSb.Clear();
				tabOffset = "";
				codeGenSb.AppendLine($"{tabOffset}namespace {ns}");
				codeGenSb.AppendLine($"{tabOffset}{{");

				tabOffset = "\t";
				codeGenSb.AppendLine($"{tabOffset}public static unsafe partial class {tech}");
				codeGenSb.AppendLine($"{tabOffset}{{");
				
				foreach (var intelMethodName in generatedSrc.Keys.OrderBy(_ => _))
				{
					codeGenSb.AppendLine(generatedSrc[intelMethodName]);
				}
				
				tabOffset = "\t";
				codeGenSb.AppendLine($"{tabOffset}}}");
				
				tabOffset = "";
				codeGenSb.AppendLine($"{tabOffset}}}");
				
				await File.WriteAllTextAsync(Path.Combine(saveToPath, $"{tech}.cs"), codeGenSb.ToString());
			}

			codeGenSb.Clear();
			tabOffset = "";
			codeGenSb.AppendLine($"{tabOffset}namespace {ns}");
			codeGenSb.AppendLine($"{tabOffset}{{");

			foreach (var t in new[] {(64, null), (128, null), (128, "i"), (128, "d"), (256, null), (256, "i"), (256, "d")})
			{
				var (size, pf) = t;
				codeGenSb.AppendLine(GenerateMType(size, pf));
			}
			tabOffset = "";
			codeGenSb.AppendLine($"{tabOffset}}}");

			await File.WriteAllTextAsync(Path.Combine(saveToPath, $"Types.cs"), codeGenSb.ToString());
		}

		private static readonly (string etype, string convFn)[] EtypeToReninterpretMethodMap = {("UI8", "AsByte"), ("SI8", "AsSByte"), ("UI16", "AsUInt16"), ("SI16", "AsInt16"), ("UI32", "AsUInt32"), ("SI32", "AsInt32"), ("UI64", "AsUInt64"), ("SI64", "AsInt64"), ("FP32", "AsSingle"), ("FP64", "AsDouble")};
		
		private static string GenerateMType(int size, string pf = null)
		{
			var mTypeName = pf == null ? $"__m{size}" : $"__m{size}{pf}" ;
			var codeGenSb = new StringBuilder();

			var csVectorTypeName = $"System.Runtime.Intrinsics.Vector{size}";
			
			var tabOffset = "\t";
			codeGenSb.AppendLine($"{tabOffset}public struct {mTypeName}");
			codeGenSb.AppendLine($"{tabOffset}{{");

			tabOffset = "\t\t";
			codeGenSb.AppendLine($"{tabOffset}private {csVectorTypeName}<byte> _;");

			foreach (var (etype, convFn) in EtypeToReninterpretMethodMap)
			{
				var csType = EtypeToCsTypeName(etype);
				codeGenSb.AppendLine($"{tabOffset}public {csVectorTypeName}<{csType}> {etype} => {csVectorTypeName}.{convFn}(_);");
			}

			foreach (var (etype, _) in EtypeToReninterpretMethodMap)
			{
				var csType = EtypeToCsTypeName(etype);
				codeGenSb.AppendLine($"{tabOffset}public static implicit operator {mTypeName}({csVectorTypeName}<{csType}> v) => new {mTypeName} {{ _ = {csVectorTypeName}.AsByte(v) }};");
			}

			tabOffset = "\t";
			codeGenSb.AppendLine($"{tabOffset}}}");
			return codeGenSb.ToString();
		}

		private static async Task Generate(string sriUrl, Regex cppIntrinsicNameMatcher, ConcurrentBag<XmlNode> intelData, ConcurrentDictionary<string, ConcurrentDictionary<string, string>> outputData)
		{
			var intelMethod2CsMethodMap = new Dictionary<string, List<CsMethod>>();

			var sriData = await FetchFileContent(sriUrl);

			var syntaxTree = CSharpSyntaxTree.ParseText(sriData);
			var compilation = CSharpCompilation.Create("Test").AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location)).AddReferences(MetadataReference.CreateFromFile(typeof(Vector128).Assembly.Location)).AddSyntaxTrees(syntaxTree);
			var semanticModel = compilation.GetSemanticModel(syntaxTree);
			var syntaxTreeRoot = (CompilationUnitSyntax) await syntaxTree.GetRootAsync();

			var methodDeclarations = syntaxTreeRoot.DescendantNodes(_ => true, true).OfType<MethodDeclarationSyntax>();

			foreach (var methodDeclaration in methodDeclarations)
			{
				SyntaxTrivia comments = default;
				if (!methodDeclaration.HasLeadingTrivia || methodDeclaration.GetLeadingTrivia().All(t => (comments = t).Kind() != SyntaxKind.SingleLineDocumentationCommentTrivia || comments.GetStructure() is not DocumentationCommentTriviaSyntax)) continue;

				Match match = default;
				var _ = ((DocumentationCommentTriviaSyntax) comments.GetStructure()).Content.OfType<XmlElementSyntax>().FirstOrDefault(x => (match = cppIntrinsicNameMatcher.Match(x.Content.ToFullString())).Success);

				if (!match.Success) continue;

				var methodSymbol = semanticModel.GetDeclaredSymbol(methodDeclaration);
				var csMethod = new CsMethod
				{
					Name = methodDeclaration.Identifier.ToString(),
					ClassPath = methodSymbol.ReceiverType.ToDisplayString(),
					Parameters = new CsMethodParam[methodSymbol.Parameters.Length]
				};

				if (IsCsIntrinsicType(methodSymbol.ReturnType.Name))
				{
					csMethod.ReturnType.Name = methodSymbol.ReturnType.Name;
					csMethod.ReturnType.TypeParameter = methodDeclaration.ReturnType is GenericNameSyntax returnType ? returnType.TypeArgumentList.Arguments[0].ToString() : null;
				}
				else if (methodSymbol.ReturnType is not INamedTypeSymbol {IsGenericType: true})
				{
					if (methodDeclaration.ReturnType is PointerTypeSyntax)
					{
						csMethod.ReturnType.Name = ((IPointerTypeSymbol) methodSymbol.ReturnType).PointedAtType.ToDisplayString();
						csMethod.ReturnType.IsPointer = true;
					}
					else
					{
						csMethod.ReturnType.Name = methodSymbol.ReturnType.ToDisplayString();
					}
				}
				else
				{
					throw new InvalidOperationException($"Unknown return type {methodSymbol.ReturnType.Name}");
				}

				for (var j = 0; j < methodSymbol.Parameters.Length; j++)
				{
					var parameter = methodDeclaration.ParameterList.Parameters[j];

					var parameterSymbol = methodSymbol.Parameters[j];
					var csParameter = new CsMethodParam {Name = parameterSymbol.Name};
					if (parameterSymbol.Type is not INamedTypeSymbol {IsGenericType: true} || !IsCsIntrinsicType(parameterSymbol.Type.Name))
					{
						if (parameter.Type is PointerTypeSyntax)
						{
							csParameter.Type = new CsType
							{
								Name = ((IPointerTypeSymbol) parameterSymbol.Type).PointedAtType.ToDisplayString(),
								IsPointer = true
							};
						}
						else
						{
							csParameter.Type = new CsType {Name = parameterSymbol.Type.ToDisplayString()};
						}

						csMethod.Parameters[j] = csParameter;
						continue;
					}

					var parameterTypeArgument = parameter.Type is GenericNameSyntax parameterType ? parameterType.TypeArgumentList.Arguments[0].ToString() : null;
					csParameter.Type = new CsType
					{
						Name = parameterSymbol.Type.Name,
						TypeParameter = parameterTypeArgument
					};
					csMethod.Parameters[j] = csParameter;
				}

				var intelName = match.Groups["fn"].Value;

				if (!intelMethod2CsMethodMap.ContainsKey(intelName))
				{
					intelMethod2CsMethodMap[intelName] = new List<CsMethod>();
				}

				intelMethod2CsMethodMap[intelName].Add(csMethod);
			}

			foreach (var (intelMethodName, csMethods) in intelMethod2CsMethodMap)
			{
				var intelDataNode = intelData.FirstOrDefault(x => x.Attributes?.GetNamedItem("name")?.Value?.AsSpan().Equals(intelMethodName, StringComparison.InvariantCultureIgnoreCase) ?? false);
				if (intelDataNode == null)
				{
					Debug.WriteLine(intelMethodName);
					continue;
				}

				var tech = intelDataNode?.Attributes?.GetNamedItem("tech")?.Value.Replace(".", "");
				var intelDataNodeReturn = intelDataNode?.SelectSingleNode("return");

				var intelMethod = new IntelMethod
				{
					Name = intelDataNode?.Attributes?.GetNamedItem("name")?.Value,
					Return = new IntelMethodParam
					{
						Name = intelDataNodeReturn?.Attributes?.GetNamedItem("varname")?.Value,
						Type = ParseIntelType(intelDataNodeReturn?.Attributes?.GetNamedItem("type")?.Value, intelDataNodeReturn?.Attributes?.GetNamedItem("etype")?.Value)
					},
					Description = intelDataNode?.SelectNodes(@"description")?.Cast<XmlNode>().Select(n => n.InnerText.Replace(Environment.NewLine, "")).FirstOrDefault(),
					Instructions = intelDataNode?.SelectNodes(@"instruction")?.Cast<XmlNode>().Select(n => $"{n?.Attributes?.GetNamedItem("name")?.Value} {n?.Attributes?.GetNamedItem("form")?.Value}").FirstOrDefault(),
				};

				var intelMethodParameters = intelDataNode?.SelectNodes(@"parameter")?.Cast<XmlNode>().Select(x => new IntelMethodParam
				{
					Name = x.Attributes?.GetNamedItem("varname")?.Value,
					Type = ParseIntelType(x.Attributes?.GetNamedItem("type")?.Value, x.Attributes?.GetNamedItem("etype")?.Value)
				}).ToArray();
				intelMethod.Parameters = intelMethodParameters.Where(x => x.Type.Name != "void" || x.Type.IsPointer).ToArray();

				if (csMethods.Count == 0)
				{
					throw new InvalidOperationException($"No method matching Intel's {intelMethodName} found in SR.Intrinsics namespace");
				}

				var csMethod = FindMostSuited(intelMethod, csMethods);
				if (!csMethod.ReturnType.IsPointer && csMethod.ReturnType.Name == "bool" && intelMethod.Return.Type.Name == "int")
				{
					intelMethod.Return.Type = new IntelType
					{
						Name = csMethod.ReturnType.Name,
						CsType = csMethod.ReturnType,
						Hint = "UI8"
					};
				}

				var mappedParameters = new List<string>();
				for (var k = 0; k < intelMethod.Parameters.Length; k++)
				{
					if (csMethod.Parameters.Length == k) break;
					var intelMethodParameter = intelMethod.Parameters[k];
					var csMethodParameter = csMethod.Parameters[k];

					if (IsCsIntrinsicType(csMethodParameter.Type.Name))
					{
						mappedParameters.Add($"{intelMethodParameter.Name}.{CsTypeNameToEtype(csMethodParameter.Type.TypeParameter)}");
						continue;
					}

					if (intelMethodParameter.Type.Name == csMethodParameter.Type.Name)
					{
						mappedParameters.Add($"{intelMethodParameter.Name}");
						continue;
					}

					if (csMethodParameter.Type.IsPointer && !intelMethodParameter.Type.IsPointer)
					{
						mappedParameters.Add($"({csMethodParameter.Type})&{intelMethodParameter.Name}");
					}
					else
					{
						mappedParameters.Add($"({csMethodParameter.Type}){intelMethodParameter.Name}");
					}
				}

				var codeGenSb = new StringBuilder();
				var tabOffset = "\t\t";
				var returnCast = "";
				if (!IsCsIntrinsicType(csMethod.ReturnType.Name) && csMethod.ReturnType.Name != intelMethod.Return.Type.Name)
				{
					returnCast = $"({intelMethod.Return.Type.ToRenderString()})";
				}

				codeGenSb.AppendLine($"{tabOffset}/// <summary>");
				codeGenSb.AppendLine($"{tabOffset}/// {intelMethod.Description}");
				codeGenSb.AppendLine($"{tabOffset}/// </summary>");
				codeGenSb.AppendLine($"{tabOffset}/// <remarks><c>{intelMethod.Instructions}</c></remarks>");
				foreach (var intelMethodParameter in intelMethod.Parameters)
				{
					codeGenSb.AppendLine($"{tabOffset}/// <param name=\"{intelMethodParameter.Name}\"><c>{intelMethodParameter.Type.Name} {{{intelMethodParameter.Type.Hint}}}</c></param>");
				}

				codeGenSb.AppendLine($"{tabOffset}/// <returns><c>{intelMethod.Return.Type.Name} {intelMethod.Return.Name} {{{intelMethod.Return.Type.Hint}}}</c></returns>");
				codeGenSb.AppendLine($"{tabOffset}public static {intelMethod.ToRenderString()} => {returnCast}{csMethod.ClassPath}.{csMethod.Name}({string.Join(", ", mappedParameters)});");

				if (!outputData.ContainsKey(tech))
				{
					outputData[tech] = new ConcurrentDictionary<string, string>();
				}
				outputData[tech][intelMethodName] = codeGenSb.ToString();
			}
		}

		private static async Task<string> FetchFileContent(string url)
		{
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(url),
			};
			var client = new HttpClient();
			var result = await client.SendAsync(request);
			return await result.Content.ReadAsStringAsync();
		}

		private static string CsTypeNameToEtype(string cst)
		{
			return cst switch
			{
				"byte" => "UI8",
				"sbyte" => "SI8",
				"ushort" => "UI16",
				"short" => "SI16",
				"uint" => "UI32",
				"int" => "SI32",
				"ulong" => "UI64",
				"long" => "SI64",
				"float" => "FP32",
				"double" => "FP64",
				_ => null
			};
		}

		private static string EtypeToCsTypeName(string et)
		{
			return et switch
			{
				"UI8" => "byte",
				"SI8" => "sbyte",
				"UI16" => "ushort",
				"SI16" => "short",
				"UI32" => "uint",
				"SI32" => "int",
				"UI64" => "ulong",
				"SI64" => "long",
				"FP32" => "float",
				"FP64" => "double",
				_ => null
			};
		}

		private static IntelType ParseIntelType(string type, string etype)
		{
			var match = IntelTypeDef.Match(type);
			if (!match.Success)
			{
				throw new InvalidOperationException($"Unknown Intel's type {type}");
			}

			static string IntelTypeNameToSystemTypeName(string itn)
			{
				return itn switch
				{
					"__int8" or "char" or "__mmask8" => "byte",
					"__int16" or "__mmask16" => "short",
					"__int32" or "__mmask32" => "int",
					"__int64" or "long long" or "__mmask64" => "long",
					_ => itn
				};
			}

			var isUnsigned = match.Groups["is_unsigned"].Success;
			var isPointer = match.Groups["is_ptr"].Success;
			var intelTypeName = IntelTypeNameToSystemTypeName(match.Groups["type_name"].Value);
			var csType = intelTypeName switch
			{
				"void" => new CsType
				{
					Name = "void",
					IsPointer = isPointer
				},
				"byte" => new CsType
				{
					Name = EtypeToCsTypeName(etype) ?? (isUnsigned ? "byte" : "sbyte"),
					IsPointer = isPointer
				},
				"short" => new CsType
				{
					Name = EtypeToCsTypeName(etype) ?? (isUnsigned ? "ushort" : "short"),
					IsPointer = isPointer
				},
				"int" => new CsType
				{
					Name = EtypeToCsTypeName(etype) ?? (isUnsigned ? "uint" : "int"),
					IsPointer = isPointer
				},
				"long" => new CsType
				{
					Name = EtypeToCsTypeName(etype) ?? (isUnsigned ? "ulong" : "long"),
					IsPointer = isPointer
				},
				"float" => new CsType
				{
					Name = "float",
					IsPointer = isPointer
				},
				"double" => new CsType
				{
					Name = "double",
					IsPointer = isPointer
				},
				"__m64" or "__m64i" or "__m64d" => new CsType
				{
					Name = "Vector64",
					IsPointer = isPointer,
					TypeParameter = EtypeToCsTypeName(etype)
				},
				"__m128" or "__m128i" or "__m128d" => new CsType
				{
					Name = "Vector128",
					IsPointer = isPointer,
					TypeParameter = EtypeToCsTypeName(etype)
				},
				"__m256" or "__m256i" or "__m256d" => new CsType
				{
					Name = "Vector256",
					IsPointer = isPointer,
					TypeParameter = EtypeToCsTypeName(etype)
				},
				_ => throw new InvalidOperationException($"No type matching Intel's {intelTypeName} found")
			};
			return new IntelType
			{
				Name = intelTypeName,
				IsPointer = isPointer,
				Hint = etype,
				CsType = csType
			};
		}

		private static bool IsCsIntrinsicType(string name) => name == nameof(Vector64) || name == nameof(Vector128) || name == nameof(Vector256);
		
		private static CsMethod FindMostSuited(IntelMethod intelMethod, List<CsMethod> csMethods)
		{
			foreach (var csMethod in csMethods.Where(csMethod => csMethod.Parameters.Length > 0 && intelMethod.Parameters[0].Type.CsType.Name == csMethod.Parameters[0].Type.Name && intelMethod.Parameters[0].Type.CsType.TypeParameter == csMethod.Parameters[0].Type.TypeParameter))
			{
				return csMethod;
			}

			return csMethods[0];
		}

		private struct CsType
		{
			public string Name;
			public string TypeParameter;
			public bool IsPointer;

			public override string ToString()
			{
				var name = TypeParameter == null ? Name : $"{Name}<{TypeParameter}>";
				return IsPointer ? $"{name}*" : $"{name}";
			}
		}

		private struct CsMethod
		{
			public string ClassPath;
			public string Name;
			public CsType ReturnType;
			public CsMethodParam[] Parameters;
			public override string ToString() => $"{ReturnType} {Name}({string.Join(", ", Parameters)})";
		}

		private struct CsMethodParam
		{
			public string Name;
			public CsType Type;
			public override string ToString() => $"{Type} {Name}";
		}

		private struct IntelType
		{
			public string Name;
			public string Hint;
			public bool IsPointer;
			public CsType CsType;
			public string ToRenderString() => IsPointer ? $"{Name}*" : $"{Name}";
			public override string ToString() => IsPointer ? $"{Name}* /* {Hint} */" : $"{Name} /* {Hint} */";
		}

		private struct IntelMethod
		{
			public string Name;
			public IntelMethodParam Return;
			public IntelMethodParam[] Parameters;
			public string Description;
			public string Instructions;
			public string ToRenderString() => $"{Return.Type.ToRenderString()} {Name}({string.Join(", ", Parameters.Select(x => x.ToRenderString()))})";
			public override string ToString() => $"{Return.Type} {Name}({string.Join(", ", Parameters)})";
		}

		private struct IntelMethodParam
		{
			public string Name;
			public IntelType Type;
			public string ToRenderString() => $"{Type.ToRenderString()} {Name}";
			public override string ToString() => $"{Type} {Name}";
		}
	}
}