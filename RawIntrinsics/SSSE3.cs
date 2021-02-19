namespace RawIntrinsics
{
	public static unsafe partial class SSSE3
	{
		/// <summary>
		/// Compute the absolute value of packed signed 16-bit integers in "a", and store the unsigned results in "dst".
		/// </summary>
		/// <remarks><c>PABSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_abs_epi16(__m128i a) => System.Runtime.Intrinsics.X86.Ssse3.Abs(a.SI16);

		/// <summary>
		/// Compute the absolute value of packed signed 32-bit integers in "a", and store the unsigned results in "dst".
		/// </summary>
		/// <remarks><c>PABSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_abs_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Ssse3.Abs(a.SI32);

		/// <summary>
		/// Compute the absolute value of packed signed 8-bit integers in "a", and store the unsigned results in "dst".
		/// </summary>
		/// <remarks><c>PABSB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_abs_epi8(__m128i a) => System.Runtime.Intrinsics.X86.Ssse3.Abs(a.SI8);

		/// <summary>
		/// Concatenate 16-byte blocks in "a" and "b" into a 32-byte temporary result, shift the result right by "imm8" bytes, and store the low 16 bytes in "dst".
		/// </summary>
		/// <remarks><c>PALIGNR xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_alignr_epi8(__m128i a, __m128i b, int imm8) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(a.UI8, b.UI8, (byte)imm8);

		/// <summary>
		/// Horizontally add adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>PHADDW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI16}</c></returns>
		public static __m128i _mm_hadd_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAdd(a.SI16, b.SI16);

		/// <summary>
		/// Horizontally add adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in "dst".
		/// </summary>
		/// <remarks><c>PHADDD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {SI32}</c></returns>
		public static __m128i _mm_hadd_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAdd(a.SI32, b.SI32);

		/// <summary>
		/// Horizontally add adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>PHADDSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI16}</c></returns>
		public static __m128i _mm_hadds_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAddSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Horizontally subtract adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>PHSUBW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI16}</c></returns>
		public static __m128i _mm_hsub_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtract(a.SI16, b.SI16);

		/// <summary>
		/// Horizontally subtract adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in "dst".
		/// </summary>
		/// <remarks><c>PHSUBD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {SI32}</c></returns>
		public static __m128i _mm_hsub_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtract(a.SI32, b.SI32);

		/// <summary>
		/// Horizontally subtract adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>PHSUBSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI16}</c></returns>
		public static __m128i _mm_hsubs_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtractSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Vertically multiply each unsigned 8-bit integer from "a" with the corresponding signed 8-bit integer from "b", producing intermediate signed 16-bit integers. Horizontally add adjacent pairs of intermediate signed 16-bit integers, and pack the saturated results in "dst".
		/// </summary>
		/// <remarks><c>PMADDUBSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {SI16}</c></returns>
		public static __m128i _mm_maddubs_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.MultiplyAddAdjacent(a.UI8, b.SI8);

		/// <summary>
		/// Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers. Truncate each intermediate integer to the 18 most significant bits, round by adding 1, and store bits [16:1] to "dst".
		/// </summary>
		/// <remarks><c>PMULHRSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_mulhrs_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.MultiplyHighRoundScale(a.SI16, b.SI16);

		/// <summary>
		/// Shuffle packed 8-bit integers in "a" according to shuffle control mask in the corresponding 8-bit element of "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSHUFB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_shuffle_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.Shuffle(a.UI8, b.UI8);

		/// <summary>
		/// Negate packed 16-bit integers in "a" when the corresponding signed 16-bit integer in "b" is negative, and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.
		/// </summary>
		/// <remarks><c>PSIGNW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_sign_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.Sign(a.SI16, b.SI16);

		/// <summary>
		/// Negate packed 32-bit integers in "a" when the corresponding signed 32-bit integer in "b" is negative, and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.
		/// </summary>
		/// <remarks><c>PSIGND xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_sign_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.Sign(a.SI32, b.SI32);

		/// <summary>
		/// Negate packed 8-bit integers in "a" when the corresponding signed 8-bit integer in "b" is negative, and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.
		/// </summary>
		/// <remarks><c>PSIGNB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_sign_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Ssse3.Sign(a.SI8, b.SI8);

	}
}
