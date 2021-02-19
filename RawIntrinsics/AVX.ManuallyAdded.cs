using System.Runtime.Intrinsics;

namespace RawIntrinsics
{
	public static partial class AVX
	{
		/// <summary>
		/// Return vector of type __m256d with all elements set to zero.
		/// </summary>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_setzero_pd() => System.Runtime.Intrinsics.Vector256<double>.Zero;
		
		/// <summary>
		/// Return vector of type __m256 with all elements set to zero.
		/// </summary>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_setzero_ps() => System.Runtime.Intrinsics.Vector256<float>.Zero;
		
		/// <summary>
		/// Return vector of type __m256i with all elements set to zero.
		/// </summary>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_setzero_si256() => System.Runtime.Intrinsics.Vector256<byte>.Zero;
	}
}