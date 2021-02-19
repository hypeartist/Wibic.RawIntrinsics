namespace RawIntrinsics
{
	public static partial class SSE2
	{
		/// <summary>
		/// Return vector of type __m128d with all elements set to zero.
		/// </summary>
		/// <returns><c>__m128d dst {M128}</c></returns>
		public static __m128d _mm_setzero_pd() => System.Runtime.Intrinsics.Vector128<double>.Zero;
		
		/// <summary>
		/// Return vector of type __m128i with all elements set to zero.
		/// </summary>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_setzero_si128() => System.Runtime.Intrinsics.Vector128<byte>.Zero;
	}
}