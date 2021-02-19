# Wibic.RawIntrinsics

.NET intrinsics represented by native intrinsics functions names. 
Those methods can make it a lot easier to port existing SIMD related C++ code into C# (I hope).

Something like this:

```csharp
var v = _mm256_set1_epi8(1);

var end = data + size;
var ptr = data;

__m256i tmp;
__m256i global_sum = _mm256_setzero_si256();
__m256i local_sum;

while (ptr + 255 * 32 < end)
{
	local_sum = _mm256_setzero_si256();

	for (var i = 0; i < 255; i++, ptr += 32)
	{
		__m256i src = _mm256_loadu_si256((__m256i*)ptr);
		__m256i eq = _mm256_cmpeq_epi8(src, v);

		local_sum = _mm256_sub_epi8(local_sum, eq);
	}

	tmp = _mm256_sad_epu8(local_sum, _mm256_setzero_si256());
	global_sum = _mm256_add_epi64(global_sum, tmp);
}
```

All methods generated using:

dotnet/runtime@master/src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/

and:

software.intel.com/sites/landingpage/IntrinsicsGuide/files/data-latest.xml

PS: Generator project also included in the repo.
