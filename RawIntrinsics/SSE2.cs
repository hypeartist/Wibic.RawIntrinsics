namespace RawIntrinsics
{
	public static unsafe partial class SSE2
	{
		/// <summary>
		/// Add packed 16-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_add_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Add(a.UI16, b.UI16);

		/// <summary>
		/// Add packed 32-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_add_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Add(a.UI32, b.UI32);

		/// <summary>
		/// Add packed 64-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="b"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_add_epi64(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Add(a.UI64, b.UI64);

		/// <summary>
		/// Add packed 8-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_add_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Add(a.UI8, b.UI8);

		/// <summary>
		/// Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ADDPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_add_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Add(a.FP64, b.FP64);

		/// <summary>
		/// Add the lower double-precision (64-bit) floating-point element in "a" and "b", store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>ADDSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_add_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.AddScalar(a.FP64, b.FP64);

		/// <summary>
		/// Add packed signed 16-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_adds_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Add packed signed 8-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDSB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_adds_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(a.SI8, b.SI8);

		/// <summary>
		/// Add packed unsigned 16-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDUSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_adds_epu16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(a.UI16, b.UI16);

		/// <summary>
		/// Add packed unsigned 8-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PADDUSB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_adds_epu8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(a.UI8, b.UI8);

		/// <summary>
		/// Compute the bitwise AND of packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ANDPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_and_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.And(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>PAND xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_and_si128(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.And(a.UI8, b.UI8);

		/// <summary>
		/// Compute the bitwise NOT of packed double-precision (64-bit) floating-point elements in "a" and then AND with "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ANDNPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_andnot_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.AndNot(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise NOT of 128 bits (representing integer data) in "a" and then AND with "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>PANDN xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_andnot_si128(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.AndNot(a.UI8, b.UI8);

		/// <summary>
		/// Average packed unsigned 16-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PAVGW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_avg_epu16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Average(a.UI16, b.UI16);

		/// <summary>
		/// Average packed unsigned 8-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PAVGB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_avg_epu8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Average(a.UI8, b.UI8);

		/// <summary>
		/// Shift "a" left by "imm8" bytes while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSLLDQ xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_bslli_si128(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(a.SI8, (byte)imm8);

		/// <summary>
		/// Shift "a" right by "imm8" bytes while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRLDQ xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_bsrli_si128(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(a.SI8, (byte)imm8);

		/// <summary>
		/// Compare packed 16-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPEQW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_cmpeq_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(a.UI16, b.UI16);

		/// <summary>
		/// Compare packed 32-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPEQD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cmpeq_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(a.UI32, b.UI32);

		/// <summary>
		/// Compare packed 8-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPEQB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_cmpeq_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(a.UI8, b.UI8);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpeq_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for equality, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpeq_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for greater-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpge_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for greater-than-or-equal, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpge_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarGreaterThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed signed 16-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPGTW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_cmpgt_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(a.SI16, b.SI16);

		/// <summary>
		/// Compare packed signed 32-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPGTD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cmpgt_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(a.SI32, b.SI32);

		/// <summary>
		/// Compare packed signed 8-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPGTB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_cmpgt_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(a.SI8, b.SI8);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpgt_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for greater-than, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpgt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarGreaterThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmple_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for less-than-or-equal, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmple_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarLessThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed signed 16-bit integers in "a" and "b" for less-than, and store the results in "dst". Note: This intrinsic emits the pcmpgtw instruction with the order of the operands switched.
		/// </summary>
		/// <remarks><c>PCMPGTW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_cmplt_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(a.SI16, b.SI16);

		/// <summary>
		/// Compare packed signed 32-bit integers in "a" and "b" for less-than, and store the results in "dst". Note: This intrinsic emits the pcmpgtd instruction with the order of the operands switched.
		/// </summary>
		/// <remarks><c>PCMPGTD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cmplt_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(a.SI32, b.SI32);

		/// <summary>
		/// Compare packed signed 8-bit integers in "a" and "b" for less-than, and store the results in "dst". Note: This intrinsic emits the pcmpgtb instruction with the order of the operands switched.
		/// </summary>
		/// <remarks><c>PCMPGTB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_cmplt_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(a.SI8, b.SI8);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmplt_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for less-than, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmplt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarLessThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpneq_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareNotEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-equal, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpneq_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-greater-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpnge_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareNotGreaterThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-greater-than-or-equal, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpnge_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotGreaterThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpngt_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareNotGreaterThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-greater-than, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpngt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotGreaterThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpnle_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareNotLessThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than-or-equal, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpnle_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotLessThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpnlt_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareNotLessThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpnlt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotLessThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if neither is NaN, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpord_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareOrdered(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" to see if neither is NaN, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpord_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrdered(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if either is NaN, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpunord_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareUnordered(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" to see if either is NaN, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CMPSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmpunord_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnordered(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for equality, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comieq_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than-or-equal, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comige_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedGreaterThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comigt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedGreaterThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than-or-equal, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comile_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedLessThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comilt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedLessThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for not-equal, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comineq_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedNotEqual(a.FP64, b.FP64);

		/// <summary>
		/// Convert packed signed 32-bit integers in "a" to packed double-precision (64-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTDQ2PD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cvtepi32_pd(__m128i a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Double(a.SI32);

		/// <summary>
		/// Convert packed signed 32-bit integers in "a" to packed single-precision (32-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTDQ2PS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cvtepi32_ps(__m128i a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Single(a.SI32);

		/// <summary>
		/// Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTPD2DQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cvtpd_epi32(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32(a.FP64);

		/// <summary>
		/// Convert packed double-precision (64-bit) floating-point elements in "a" to packed single-precision (32-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTPD2PS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cvtpd_ps(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Single(a.FP64);

		/// <summary>
		/// Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTPS2DQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cvtps_epi32(__m128 a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32(a.FP32);

		/// <summary>
		/// Convert packed single-precision (32-bit) floating-point elements in "a" to packed double-precision (64-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTPS2PD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cvtps_pd(__m128 a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Double(a.FP32);

		/// <summary>
		/// Convert the lower double-precision (64-bit) floating-point element in "a" to a 32-bit integer, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTSD2SI r32, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_cvtsd_si32(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32(a.FP64);

		/// <summary>
		/// Convert the lower double-precision (64-bit) floating-point element in "a" to a 64-bit integer, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTSD2SI r64, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_cvtsd_si64(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64(a.FP64);

		/// <summary>
		/// Convert the lower double-precision (64-bit) floating-point element in "b" to a single-precision (32-bit) floating-point element, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CVTSD2SS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cvtsd_ss(__m128 a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Single(a.FP32, b.FP64);

		/// <summary>
		/// Copy the lower 32-bit integer in "a" to "dst".
		/// </summary>
		/// <remarks><c>MOVD r32, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_cvtsi128_si32(__m128i a) => (int)System.Runtime.Intrinsics.X86.Sse2.ConvertToUInt32(a.UI32);

		/// <summary>
		/// Copy the lower 64-bit integer in "a" to "dst".
		/// </summary>
		/// <remarks><c>MOVQ r64, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_cvtsi128_si64(__m128i a) => (long)System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToUInt64(a.UI64);

		/// <summary>
		/// Convert the signed 32-bit integer "b" to a double-precision (64-bit) floating-point element, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CVTSI2SD xmm, r32</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>int {SI32}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cvtsi32_sd(__m128d a, int b) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Double(a.FP64, b);

		/// <summary>
		/// Copy 32-bit integer "a" to the lower elements of "dst", and zero the upper elements of "dst".
		/// </summary>
		/// <remarks><c>MOVD xmm, r32</c></remarks>
		/// <param name="a"><c>int {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cvtsi32_si128(int a) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128UInt32((uint)a);

		/// <summary>
		/// Convert the signed 64-bit integer "b" to a double-precision (64-bit) floating-point element, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CVTSI2SD xmm, r64</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>long {SI64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cvtsi64_sd(__m128d a, long b) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128Double(a.FP64, b);

		/// <summary>
		/// Copy 64-bit integer "a" to the lower element of "dst", and zero the upper element.
		/// </summary>
		/// <remarks><c>MOVQ xmm, r64</c></remarks>
		/// <param name="a"><c>long {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_cvtsi64_si128(long a) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128UInt64((ulong)a);

		/// <summary>
		/// Convert the lower single-precision (32-bit) floating-point element in "b" to a double-precision (64-bit) floating-point element, store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>CVTSS2SD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cvtss_sd(__m128d a, __m128 b) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Double(a.FP64, b.FP32);

		/// <summary>
		/// Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers with truncation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTTPD2DQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cvttpd_epi32(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32WithTruncation(a.FP64);

		/// <summary>
		/// Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers with truncation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CVTTPS2DQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cvttps_epi32(__m128 a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32WithTruncation(a.FP32);

		/// <summary>
		/// Convert the lower double-precision (64-bit) floating-point element in "a" to a 32-bit integer with truncation, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTTSD2SI r32, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_cvttsd_si32(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32WithTruncation(a.FP64);

		/// <summary>
		/// Convert the lower double-precision (64-bit) floating-point element in "a" to a 64-bit integer with truncation, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTTSD2SI r64, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_cvttsd_si64(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64WithTruncation(a.FP64);

		/// <summary>
		/// Divide packed double-precision (64-bit) floating-point elements in "a" by packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>DIVPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_div_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Divide(a.FP64, b.FP64);

		/// <summary>
		/// Divide the lower double-precision (64-bit) floating-point element in "a" by the lower double-precision (64-bit) floating-point element in "b", store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>DIVSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_div_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.DivideScalar(a.FP64, b.FP64);

		/// <summary>
		/// Extract a 16-bit integer from "a", selected with "imm8", and store the result in the lower element of "dst".
		/// </summary>
		/// <remarks><c>PEXTRW r32, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>int dst {UI16}</c></returns>
		public static int _mm_extract_epi16(__m128i a, int imm8) => (int)System.Runtime.Intrinsics.X86.Sse2.Extract(a.UI16, (byte)imm8);

		/// <summary>
		/// Copy "a" to "dst", and insert the 16-bit integer "i" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>PINSRW xmm, r32, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="i"><c>int {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_insert_epi16(__m128i a, int i, int imm8) => System.Runtime.Intrinsics.X86.Sse2.Insert(a.UI16, (ushort)i, (byte)imm8);

		/// <summary>
		/// Perform a serializing operation on all load-from-memory instructions that were issued prior to this instruction. Guarantees that every load instruction that precedes, in program order, is globally visible before any load instruction which follows the fence in program order.
		/// </summary>
		/// <remarks><c>LFENCE </c></remarks>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_lfence() => System.Runtime.Intrinsics.X86.Sse2.LoadFence();

		/// <summary>
		/// Load 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from memory into "dst".	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVAPD xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_load_pd(double* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(mem_addr);

		/// <summary>
		/// Load a double-precision (64-bit) floating-point element from memory into the lower of "dst", and zero the upper element. "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVSD xmm, m64</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_load_sd(double* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(mem_addr);

		/// <summary>
		/// Load 128-bits of integer data from memory into "dst". 	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVDQA xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_load_si128(__m128i* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128((sbyte*)mem_addr);

		/// <summary>
		/// Load a double-precision (64-bit) floating-point element from memory into the upper element of "dst", and copy the lower element from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVHPD xmm, m64</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_loadh_pd(__m128d a, double* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadHigh(a.FP64, mem_addr);

		/// <summary>
		/// Load 64-bit integer from memory into the first element of "dst".
		/// </summary>
		/// <remarks><c>MOVQ xmm, m64</c></remarks>
		/// <param name="mem_addr"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_loadl_epi64(__m128i* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128((long*)mem_addr);

		/// <summary>
		/// Load a double-precision (64-bit) floating-point element from memory into the lower element of "dst", and copy the upper element from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVLPD xmm, m64</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_loadl_pd(__m128d a, double* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadLow(a.FP64, mem_addr);

		/// <summary>
		/// Load 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from memory into "dst".	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVUPD xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_loadu_pd(double* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(mem_addr);

		/// <summary>
		/// Load 128-bits of integer data from memory into "dst".	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVDQU xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_loadu_si128(__m128i* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128((sbyte*)mem_addr);

		/// <summary>
		/// Load unaligned 32-bit integer from memory into the first element of "dst".
		/// </summary>
		/// <remarks><c>MOVD xmm, m32</c></remarks>
		/// <param name="mem_addr"><c>void {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_loadu_si32(void* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128((int*)mem_addr);

		/// <summary>
		/// Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers. Horizontally add adjacent pairs of intermediate 32-bit integers, and pack the results in "dst".
		/// </summary>
		/// <remarks><c>PMADDWD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI32}</c></returns>
		public static __m128i _mm_madd_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.MultiplyAddAdjacent(a.SI16, b.SI16);

		/// <summary>
		/// Conditionally store 8-bit integer elements from "a" into memory using "mask" (elements are not stored when the highest bit is not set in the corresponding element) and a non-temporal memory hint. "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MASKMOVDQU xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="mask"><c>__m128i {UI8}</c></param>
		/// <param name="mem_addr"><c>byte {UI8}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_maskmoveu_si128(__m128i a, __m128i mask, byte* mem_addr) => System.Runtime.Intrinsics.X86.Sse2.MaskMove(a.UI8, mask.UI8, mem_addr);

		/// <summary>
		/// Compare packed signed 16-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>PMAXSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_max_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Max(a.SI16, b.SI16);

		/// <summary>
		/// Compare packed unsigned 8-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>PMAXUB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_max_epu8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Max(a.UI8, b.UI8);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>MAXPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_max_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Max(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b", store the maximum value in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>MAXSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_max_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.MaxScalar(a.FP64, b.FP64);

		/// <summary>
		/// Perform a serializing operation on all load-from-memory and store-to-memory instructions that were issued prior to this instruction. Guarantees that every memory access that precedes, in program order, the memory fence instruction is globally visible before any memory instruction which follows the fence in program order.
		/// </summary>
		/// <remarks><c>MFENCE </c></remarks>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_mfence() => System.Runtime.Intrinsics.X86.Sse2.MemoryFence();

		/// <summary>
		/// Compare packed signed 16-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>PMINSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_min_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Min(a.SI16, b.SI16);

		/// <summary>
		/// Compare packed unsigned 8-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>PMINUB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_min_epu8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Min(a.UI8, b.UI8);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>MINPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_min_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Min(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point elements in "a" and "b", store the minimum value in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>MINSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_min_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.MinScalar(a.FP64, b.FP64);

		/// <summary>
		/// Copy the lower 64-bit integer in "a" to the lower element of "dst", and zero the upper element.
		/// </summary>
		/// <remarks><c>MOVQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_move_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(a.UI64);

		/// <summary>
		/// Move the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>MOVSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_move_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(a.FP64, b.FP64);

		/// <summary>
		/// Create mask from the most significant bit of each 8-bit element in "a", and store the result in "dst".
		/// </summary>
		/// <remarks><c>PMOVMSKB r32, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>int dst {MASK}</c></returns>
		public static int _mm_movemask_epi8(__m128i a) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(a.UI8);

		/// <summary>
		/// Set each bit of mask "dst" based on the most significant bit of the corresponding packed double-precision (64-bit) floating-point element in "a".
		/// </summary>
		/// <remarks><c>MOVMSKPD r32, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>int dst {MASK}</c></returns>
		public static int _mm_movemask_pd(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(a.FP64);

		/// <summary>
		/// Multiply the low unsigned 32-bit integers from each packed 64-bit element in "a" and "b", and store the unsigned 64-bit results in "dst".
		/// </summary>
		/// <remarks><c>PMULUDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_mul_epu32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Multiply(a.UI32, b.UI32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>MULPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_mul_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Multiply(a.FP64, b.FP64);

		/// <summary>
		/// Multiply the lower double-precision (64-bit) floating-point element in "a" and "b", store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>MULSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_mul_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.MultiplyScalar(a.FP64, b.FP64);

		/// <summary>
		/// Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the high 16 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>PMULHW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_mulhi_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.MultiplyHigh(a.SI16, b.SI16);

		/// <summary>
		/// Multiply the packed unsigned 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the high 16 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>PMULHUW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_mulhi_epu16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.MultiplyHigh(a.UI16, b.UI16);

		/// <summary>
		/// Multiply the packed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the low 16 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>PMULLW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_mullo_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.MultiplyLow(a.UI16, b.UI16);

		/// <summary>
		/// Compute the bitwise OR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ORPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_or_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Or(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise OR of 128 bits (representing integer data) in "a" and "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>POR xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_or_si128(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Or(a.UI8, b.UI8);

		/// <summary>
		/// Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using signed saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PACKSSWB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI8}</c></returns>
		public static __m128i _mm_packs_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.PackSignedSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using signed saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PACKSSDW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {SI16}</c></returns>
		public static __m128i _mm_packs_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.PackSignedSaturate(a.SI32, b.SI32);

		/// <summary>
		/// Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using unsigned saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PACKUSWB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_packus_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.PackUnsignedSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Compute the absolute differences of packed unsigned 8-bit integers in "a" and "b", then horizontally sum each consecutive 8 differences to produce two unsigned 16-bit integers, and pack these unsigned 16-bit integers in the low 16 bits of 64-bit elements in "dst".
		/// </summary>
		/// <remarks><c>PSADBW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_sad_epu8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.SumAbsoluteDifferences(a.UI8, b.UI8);

		/// <summary>
		/// Broadcast 16-bit integer "a" to all all elements of "dst". This intrinsic may generate "vpbroadcastw".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>short {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_set1_epi16(short a) => System.Runtime.Intrinsics.Vector128.Create((ushort)a);

		/// <summary>
		/// Broadcast 32-bit integer "a" to all elements of "dst". This intrinsic may generate "vpbroadcastd".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>int {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_set1_epi32(int a) => System.Runtime.Intrinsics.Vector128.Create((uint)a);

		/// <summary>
		/// Broadcast 64-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastq".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>long {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_set1_epi64x(long a) => System.Runtime.Intrinsics.Vector128.Create((ulong)a);

		/// <summary>
		/// Broadcast 8-bit integer "a" to all elements of "dst". This intrinsic may generate "vpbroadcastb".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>byte {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_set1_epi8(byte a) => System.Runtime.Intrinsics.Vector128.Create(a);

		/// <summary>
		/// Broadcast double-precision (64-bit) floating-point value "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_set1_pd(double a) => System.Runtime.Intrinsics.Vector128.Create(a);

		/// <summary>
		/// Set packed 16-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e7"><c>short {UI16}</c></param>
		/// <param name="e6"><c>short {UI16}</c></param>
		/// <param name="e5"><c>short {UI16}</c></param>
		/// <param name="e4"><c>short {UI16}</c></param>
		/// <param name="e3"><c>short {UI16}</c></param>
		/// <param name="e2"><c>short {UI16}</c></param>
		/// <param name="e1"><c>short {UI16}</c></param>
		/// <param name="e0"><c>short {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_setr_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) => System.Runtime.Intrinsics.Vector128.Create((ushort)e7, (ushort)e6, (ushort)e5, (ushort)e4, (ushort)e3, (ushort)e2, (ushort)e1, (ushort)e0);

		/// <summary>
		/// Set packed 32-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e3"><c>int {UI32}</c></param>
		/// <param name="e2"><c>int {UI32}</c></param>
		/// <param name="e1"><c>int {UI32}</c></param>
		/// <param name="e0"><c>int {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_setr_epi32(int e3, int e2, int e1, int e0) => System.Runtime.Intrinsics.Vector128.Create((uint)e3, (uint)e2, (uint)e1, (uint)e0);

		/// <summary>
		/// Set packed 64-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e1"><c>__m64 {UI64}</c></param>
		/// <param name="e0"><c>__m64 {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_setr_epi64(__m64 e1, __m64 e0) => System.Runtime.Intrinsics.Vector128.Create(e1.SI32, e0.SI32);

		/// <summary>
		/// Set packed 8-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e15"><c>byte {UI8}</c></param>
		/// <param name="e14"><c>byte {UI8}</c></param>
		/// <param name="e13"><c>byte {UI8}</c></param>
		/// <param name="e12"><c>byte {UI8}</c></param>
		/// <param name="e11"><c>byte {UI8}</c></param>
		/// <param name="e10"><c>byte {UI8}</c></param>
		/// <param name="e9"><c>byte {UI8}</c></param>
		/// <param name="e8"><c>byte {UI8}</c></param>
		/// <param name="e7"><c>byte {UI8}</c></param>
		/// <param name="e6"><c>byte {UI8}</c></param>
		/// <param name="e5"><c>byte {UI8}</c></param>
		/// <param name="e4"><c>byte {UI8}</c></param>
		/// <param name="e3"><c>byte {UI8}</c></param>
		/// <param name="e2"><c>byte {UI8}</c></param>
		/// <param name="e1"><c>byte {UI8}</c></param>
		/// <param name="e0"><c>byte {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_setr_epi8(byte e15, byte e14, byte e13, byte e12, byte e11, byte e10, byte e9, byte e8, byte e7, byte e6, byte e5, byte e4, byte e3, byte e2, byte e1, byte e0) => System.Runtime.Intrinsics.Vector128.Create(e15, e14, e13, e12, e11, e10, e9, e8, e7, e6, e5, e4, e3, e2, e1, e0);

		/// <summary>
		/// Set packed double-precision (64-bit) floating-point elements in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e1"><c>double {FP64}</c></param>
		/// <param name="e0"><c>double {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_setr_pd(double e1, double e0) => System.Runtime.Intrinsics.Vector128.Create(e1, e0);

		/// <summary>
		/// Shuffle 32-bit integers in "a" using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSHUFD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_shuffle_epi32(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(a.UI32, (byte)imm8);

		/// <summary>
		/// Shuffle double-precision (64-bit) floating-point elements using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>SHUFPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_shuffle_pd(__m128d a, __m128d b, int imm8) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(a.FP64, b.FP64, (byte)imm8);

		/// <summary>
		/// Shuffle 16-bit integers in the high 64 bits of "a" using the control in "imm8". Store the results in the high 64 bits of "dst", with the low 64 bits being copied from from "a" to "dst".
		/// </summary>
		/// <remarks><c>PSHUFHW xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_shufflehi_epi16(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShuffleHigh(a.UI16, (byte)imm8);

		/// <summary>
		/// Shuffle 16-bit integers in the low 64 bits of "a" using the control in "imm8". Store the results in the low 64 bits of "dst", with the high 64 bits being copied from from "a" to "dst".
		/// </summary>
		/// <remarks><c>PSHUFLW xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_shufflelo_epi16(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShuffleLow(a.UI16, (byte)imm8);

		/// <summary>
		/// Shift packed 16-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSLLW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="count"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_sll_epi16(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(a.UI16, count.UI16);

		/// <summary>
		/// Shift packed 32-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSLLD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_sll_epi32(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSLLQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="count"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_sll_epi64(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(a.UI64, count.UI64);

		/// <summary>
		/// Shift packed 16-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSLLW xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_slli_epi16(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(a.UI16, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSLLD xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_slli_epi32(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(a.UI32, (byte)imm8);

		/// <summary>
		/// Shift packed 64-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSLLQ xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_slli_epi64(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(a.UI64, (byte)imm8);

		/// <summary>
		/// Compute the square root of packed double-precision (64-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>SQRTPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_sqrt_pd(__m128d a) => System.Runtime.Intrinsics.X86.Sse2.Sqrt(a.FP64);

		/// <summary>
		/// Compute the square root of the lower double-precision (64-bit) floating-point element in "b", store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>SQRTSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_sqrt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.SqrtScalar(a.FP64);

		/// <summary>
		/// Shift packed 16-bit integers in "a" right by "count" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRAW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="count"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_sra_epi16(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(a.SI16, count.SI16);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by "count" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRAD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_sra_epi32(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(a.SI32, count.SI32);

		/// <summary>
		/// Shift packed 16-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRAW xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_srai_epi16(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(a.SI16, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRAD xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_srai_epi32(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(a.SI32, (byte)imm8);

		/// <summary>
		/// Shift packed 16-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRLW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="count"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_srl_epi16(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(a.UI16, count.UI16);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRLD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_srl_epi32(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRLQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="count"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_srl_epi64(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(a.UI64, count.UI64);

		/// <summary>
		/// Shift packed 16-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRLW xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_srli_epi16(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(a.UI16, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRLD xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_srli_epi32(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(a.UI32, (byte)imm8);

		/// <summary>
		/// Shift packed 64-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSRLQ xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_srli_epi64(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(a.UI64, (byte)imm8);

		/// <summary>
		/// Store 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a" into memory.	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVAPD m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_store_pd(double* mem_addr, __m128d a) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(mem_addr, a.FP64);

		/// <summary>
		/// Store the lower double-precision (64-bit) floating-point element from "a" into memory. "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVSD m64, xmm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_store_sd(double* mem_addr, __m128d a) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar(mem_addr, a.FP64);

		/// <summary>
		/// Store 128-bits of integer data from "a" into memory. 	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVDQA m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>__m128i {M128}</c></param>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_store_si128(__m128i* mem_addr, __m128i a) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned((sbyte*)mem_addr, a.SI8);

		/// <summary>
		/// Store the upper double-precision (64-bit) floating-point element from "a" into memory.
		/// </summary>
		/// <remarks><c>MOVHPD m64, xmm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storeh_pd(double* mem_addr, __m128d a) => System.Runtime.Intrinsics.X86.Sse2.StoreHigh(mem_addr, a.FP64);

		/// <summary>
		/// Store 64-bit integer from the first element of "a" into memory.
		/// </summary>
		/// <remarks><c>MOVQ m64, xmm</c></remarks>
		/// <param name="mem_addr"><c>__m128i {UI64}</c></param>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storel_epi64(__m128i* mem_addr, __m128i a) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar((long*)mem_addr, a.SI64);

		/// <summary>
		/// Store the lower double-precision (64-bit) floating-point element from "a" into memory.
		/// </summary>
		/// <remarks><c>MOVLPD m64, xmm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storel_pd(double* mem_addr, __m128d a) => System.Runtime.Intrinsics.X86.Sse2.StoreLow(mem_addr, a.FP64);

		/// <summary>
		/// Store 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a" into memory.	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVUPD m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storeu_pd(double* mem_addr, __m128d a) => System.Runtime.Intrinsics.X86.Sse2.Store(mem_addr, a.FP64);

		/// <summary>
		/// Store 128-bits of integer data from "a" into memory.	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVDQU m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>__m128i {M128}</c></param>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storeu_si128(__m128i* mem_addr, __m128i a) => System.Runtime.Intrinsics.X86.Sse2.Store((sbyte*)mem_addr, a.SI8);

		/// <summary>
		/// Store 32-bit integer from the first element of "a" into memory. "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVD m32, xmm</c></remarks>
		/// <param name="mem_addr"><c>void {UI32}</c></param>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storeu_si32(void* mem_addr, __m128i a) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar((int*)mem_addr, a.SI32);

		/// <summary>
		/// Store 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a" into memory using a non-temporal memory hint.	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVNTPD m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_stream_pd(double* mem_addr, __m128d a) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(mem_addr, a.FP64);

		/// <summary>
		/// Store 128-bits of integer data from "a" into memory using a non-temporal memory hint. 	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVNTDQ m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>__m128i {M128}</c></param>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_stream_si128(__m128i* mem_addr, __m128i a) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal((sbyte*)mem_addr, a.SI8);

		/// <summary>
		/// Store 32-bit integer "a" into memory using a non-temporal hint to minimize cache pollution. If the cache line containing address "mem_addr" is already in the cache, the cache will be updated.
		/// </summary>
		/// <remarks><c>MOVNTI m32, r32</c></remarks>
		/// <param name="mem_addr"><c>int {UI32}</c></param>
		/// <param name="a"><c>int {UI32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_stream_si32(int* mem_addr, int a) => System.Runtime.Intrinsics.X86.Sse2.StoreNonTemporal((uint*)mem_addr, (uint)a);

		/// <summary>
		/// Store 64-bit integer "a" into memory using a non-temporal hint to minimize cache pollution. If the cache line containing address "mem_addr" is already in the cache, the cache will be updated.
		/// </summary>
		/// <remarks><c>MOVNTI m64, r64</c></remarks>
		/// <param name="mem_addr"><c>long {UI64}</c></param>
		/// <param name="a"><c>long {UI64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_stream_si64(long* mem_addr, long a) => System.Runtime.Intrinsics.X86.Sse2.X64.StoreNonTemporal((ulong*)mem_addr, (ulong)a);

		/// <summary>
		/// Subtract packed 16-bit integers in "b" from packed 16-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_sub_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Subtract(a.UI16, b.UI16);

		/// <summary>
		/// Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_sub_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Subtract(a.UI32, b.UI32);

		/// <summary>
		/// Subtract packed 64-bit integers in "b" from packed 64-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="b"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_sub_epi64(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Subtract(a.UI64, b.UI64);

		/// <summary>
		/// Subtract packed 8-bit integers in "b" from packed 8-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_sub_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Subtract(a.UI8, b.UI8);

		/// <summary>
		/// Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>SUBPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_sub_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Subtract(a.FP64, b.FP64);

		/// <summary>
		/// Subtract the lower double-precision (64-bit) floating-point element in "b" from the lower double-precision (64-bit) floating-point element in "a", store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>SUBSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_sub_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.SubtractScalar(a.FP64, b.FP64);

		/// <summary>
		/// Subtract packed signed 16-bit integers in "b" from packed 16-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <param name="b"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_subs_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Subtract packed signed 8-bit integers in "b" from packed 8-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBSB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_subs_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(a.SI8, b.SI8);

		/// <summary>
		/// Subtract packed unsigned 16-bit integers in "b" from packed unsigned 16-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBUSW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_subs_epu16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(a.UI16, b.UI16);

		/// <summary>
		/// Subtract packed unsigned 8-bit integers in "b" from packed unsigned 8-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PSUBUSB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_subs_epu8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(a.UI8, b.UI8);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for equality, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomieq_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than-or-equal, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomige_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedGreaterThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomigt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedGreaterThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than-or-equal, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomile_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedLessThanOrEqual(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomilt_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedLessThan(a.FP64, b.FP64);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for not-equal, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomineq_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedNotEqual(a.FP64, b.FP64);

		/// <summary>
		/// Unpack and interleave 16-bit integers from the high half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKHWD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_unpackhi_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(a.UI16, b.UI16);

		/// <summary>
		/// Unpack and interleave 32-bit integers from the high half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKHDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_unpackhi_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(a.UI32, b.UI32);

		/// <summary>
		/// Unpack and interleave 64-bit integers from the high half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKHQDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="b"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_unpackhi_epi64(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(a.UI64, b.UI64);

		/// <summary>
		/// Unpack and interleave 8-bit integers from the high half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKHBW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_unpackhi_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(a.UI8, b.UI8);

		/// <summary>
		/// Unpack and interleave double-precision (64-bit) floating-point elements from the high half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>UNPCKHPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_unpackhi_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(a.FP64, b.FP64);

		/// <summary>
		/// Unpack and interleave 16-bit integers from the low half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKLWD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_unpacklo_epi16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(a.UI16, b.UI16);

		/// <summary>
		/// Unpack and interleave 32-bit integers from the low half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKLDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_unpacklo_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(a.UI32, b.UI32);

		/// <summary>
		/// Unpack and interleave 64-bit integers from the low half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKLQDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="b"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_unpacklo_epi64(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(a.UI64, b.UI64);

		/// <summary>
		/// Unpack and interleave 8-bit integers from the low half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PUNPCKLBW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_unpacklo_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(a.UI8, b.UI8);

		/// <summary>
		/// Unpack and interleave double-precision (64-bit) floating-point elements from the low half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>UNPCKLPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_unpacklo_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise XOR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>XORPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_xor_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse2.Xor(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise XOR of 128 bits (representing integer data) in "a" and "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>PXOR xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_xor_si128(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse2.Xor(a.UI8, b.UI8);

	}
}
