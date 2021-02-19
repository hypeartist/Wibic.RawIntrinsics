namespace RawIntrinsics
{
	public static unsafe partial class SSE3
	{
		/// <summary>
		/// Alternatively add and subtract packed double-precision (64-bit) floating-point elements in "a" to/from packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ADDSUBPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_addsub_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse3.AddSubtract(a.FP64, b.FP64);

		/// <summary>
		/// Alternatively add and subtract packed single-precision (32-bit) floating-point elements in "a" to/from packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ADDSUBPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_addsub_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse3.AddSubtract(a.FP32, b.FP32);

		/// <summary>
		/// Horizontally add adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>HADDPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_hadd_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse3.HorizontalAdd(a.FP64, b.FP64);

		/// <summary>
		/// Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>HADDPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_hadd_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse3.HorizontalAdd(a.FP32, b.FP32);

		/// <summary>
		/// Horizontally subtract adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>HSUBPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_hsub_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse3.HorizontalSubtract(a.FP64, b.FP64);

		/// <summary>
		/// Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>HSUBPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_hsub_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse3.HorizontalSubtract(a.FP32, b.FP32);

		/// <summary>
		/// Load 128-bits of integer data from unaligned memory into "dst". This intrinsic may perform better than "_mm_loadu_si128" when the data crosses a cache line boundary.
		/// </summary>
		/// <remarks><c>LDDQU xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_lddqu_si128(__m128i* mem_addr) => System.Runtime.Intrinsics.X86.Sse3.LoadDquVector128((sbyte*)mem_addr);

		/// <summary>
		/// Load a double-precision (64-bit) floating-point element from memory into both elements of "dst".
		/// </summary>
		/// <remarks><c>MOVDDUP xmm, m64</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_loaddup_pd(double* mem_addr) => System.Runtime.Intrinsics.X86.Sse3.LoadAndDuplicateToVector128(mem_addr);

		/// <summary>
		/// Duplicate the low double-precision (64-bit) floating-point element from "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>MOVDDUP xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_movedup_pd(__m128d a) => System.Runtime.Intrinsics.X86.Sse3.MoveAndDuplicate(a.FP64);

		/// <summary>
		/// Duplicate odd-indexed single-precision (32-bit) floating-point elements from "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>MOVSHDUP xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_movehdup_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse3.MoveHighAndDuplicate(a.FP32);

		/// <summary>
		/// Duplicate even-indexed single-precision (32-bit) floating-point elements from "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>MOVSLDUP xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_moveldup_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse3.MoveLowAndDuplicate(a.FP32);

	}
}
