namespace RawIntrinsics
{
	public static unsafe partial class SSE42
	{
		/// <summary>
		/// Compare packed signed 64-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPGTQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI64}</c></param>
		/// <param name="b"><c>__m128i {SI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_cmpgt_epi64(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse42.CompareGreaterThan(a.SI64, b.SI64);

	}
}
