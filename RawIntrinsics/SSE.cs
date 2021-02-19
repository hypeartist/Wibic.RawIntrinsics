namespace RawIntrinsics
{
	public static unsafe partial class SSE
	{
		/// <summary>
		/// Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ADDPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_add_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Add(a.FP32, b.FP32);

		/// <summary>
		/// Add the lower single-precision (32-bit) floating-point element in "a" and "b", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>ADDSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_add_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.AddScalar(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ANDPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_and_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.And(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise NOT of packed single-precision (32-bit) floating-point elements in "a" and then AND with "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ANDNPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_andnot_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.AndNot(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpeq_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for equality, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpeq_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for greater-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpge_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareGreaterThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for greater-than-or-equal, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpge_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarGreaterThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpgt_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareGreaterThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for greater-than, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpgt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarGreaterThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmple_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareLessThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for less-than-or-equal, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmple_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarLessThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmplt_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareLessThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for less-than, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmplt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarLessThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpneq_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareNotEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-equal, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpneq_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-greater-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpnge_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareNotGreaterThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-greater-than-or-equal, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpnge_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotGreaterThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpngt_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareNotGreaterThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-greater-than, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpngt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotGreaterThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than-or-equal, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpnle_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareNotLessThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than-or-equal, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpnle_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotLessThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpnlt_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareNotLessThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpnlt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotLessThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if neither is NaN, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpord_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareOrdered(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" to see if neither is NaN, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpord_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrdered(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if either is NaN, and store the results in "dst".
		/// </summary>
		/// <remarks><c>CMPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpunord_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareUnordered(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" to see if either is NaN, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CMPSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmpunord_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnordered(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for equality, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comieq_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than-or-equal, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comige_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedGreaterThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comigt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedGreaterThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than-or-equal, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comile_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedLessThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comilt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedLessThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for not-equal, and return the boolean result (0 or 1).
		/// </summary>
		/// <remarks><c>COMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_comineq_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedNotEqual(a.FP32, b.FP32);

		/// <summary>
		/// Convert the signed 32-bit integer "b" to a single-precision (32-bit) floating-point element, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CVTSI2SS xmm, r32</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>int {SI32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cvtsi32_ss(__m128 a, int b) => System.Runtime.Intrinsics.X86.Sse.ConvertScalarToVector128Single(a.FP32, b);

		/// <summary>
		/// Convert the signed 64-bit integer "b" to a single-precision (32-bit) floating-point element, store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>CVTSI2SS xmm, r64</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>long {SI64}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cvtsi64_ss(__m128 a, long b) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertScalarToVector128Single(a.FP32, b);

		/// <summary>
		/// Convert the lower single-precision (32-bit) floating-point element in "a" to a 32-bit integer, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTSS2SI r32, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_cvtss_si32(__m128 a) => System.Runtime.Intrinsics.X86.Sse.ConvertToInt32(a.FP32);

		/// <summary>
		/// Convert the lower single-precision (32-bit) floating-point element in "a" to a 64-bit integer, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTSS2SI r64, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_cvtss_si64(__m128 a) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertToInt64(a.FP32);

		/// <summary>
		/// Convert the lower single-precision (32-bit) floating-point element in "a" to a 32-bit integer with truncation, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTTSS2SI r32, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_cvttss_si32(__m128 a) => System.Runtime.Intrinsics.X86.Sse.ConvertToInt32WithTruncation(a.FP32);

		/// <summary>
		/// Convert the lower single-precision (32-bit) floating-point element in "a" to a 64-bit integer with truncation, and store the result in "dst".
		/// </summary>
		/// <remarks><c>CVTTSS2SI r64, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_cvttss_si64(__m128 a) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertToInt64WithTruncation(a.FP32);

		/// <summary>
		/// Divide packed single-precision (32-bit) floating-point elements in "a" by packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>DIVPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_div_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Divide(a.FP32, b.FP32);

		/// <summary>
		/// Divide the lower single-precision (32-bit) floating-point element in "a" by the lower single-precision (32-bit) floating-point element in "b", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>DIVSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_div_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.DivideScalar(a.FP32, b.FP32);

		/// <summary>
		/// Load 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from memory into "dst".	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVAPS xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_load_ps(float* mem_addr) => System.Runtime.Intrinsics.X86.Sse.LoadAlignedVector128(mem_addr);

		/// <summary>
		/// Load a single-precision (32-bit) floating-point element from memory into the lower of "dst", and zero the upper 3 elements. "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVSS xmm, m32</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_load_ss(float* mem_addr) => System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(mem_addr);

		/// <summary>
		/// Load 2 single-precision (32-bit) floating-point elements from memory into the upper 2 elements of "dst", and copy the lower 2 elements from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVHPS xmm, m64</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="mem_addr"><c>__m64 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_loadh_pi(__m128 a, __m64* mem_addr) => System.Runtime.Intrinsics.X86.Sse.LoadHigh(a.FP32, (float*)mem_addr);

		/// <summary>
		/// Load 2 single-precision (32-bit) floating-point elements from memory into the lower 2 elements of "dst", and copy the upper 2 elements from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVLPS xmm, m64</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="mem_addr"><c>__m64 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_loadl_pi(__m128 a, __m64* mem_addr) => System.Runtime.Intrinsics.X86.Sse.LoadLow(a.FP32, (float*)mem_addr);

		/// <summary>
		/// Load 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from memory into "dst".	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVUPS xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_loadu_ps(float* mem_addr) => System.Runtime.Intrinsics.X86.Sse.LoadVector128(mem_addr);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>MAXPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_max_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Max(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b", store the maximum value in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>MAXSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_max_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.MaxScalar(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>MINPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_min_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Min(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point elements in "a" and "b", store the minimum value in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>MINSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_min_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.MinScalar(a.FP32, b.FP32);

		/// <summary>
		/// Move the lower single-precision (32-bit) floating-point element from "b" to the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>MOVSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_move_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.MoveScalar(a.FP32, b.FP32);

		/// <summary>
		/// Move the upper 2 single-precision (32-bit) floating-point elements from "b" to the lower 2 elements of "dst", and copy the upper 2 elements from "a" to the upper 2 elements of "dst".
		/// </summary>
		/// <remarks><c>MOVHLPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_movehl_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.MoveHighToLow(a.FP32, b.FP32);

		/// <summary>
		/// Move the lower 2 single-precision (32-bit) floating-point elements from "b" to the upper 2 elements of "dst", and copy the lower 2 elements from "a" to the lower 2 elements of "dst".
		/// </summary>
		/// <remarks><c>MOVLHPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_movelh_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.MoveLowToHigh(a.FP32, b.FP32);

		/// <summary>
		/// Set each bit of mask "dst" based on the most significant bit of the corresponding packed single-precision (32-bit) floating-point element in "a".
		/// </summary>
		/// <remarks><c>MOVMSKPS r32, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_movemask_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse.MoveMask(a.FP32);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>MULPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_mul_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Multiply(a.FP32, b.FP32);

		/// <summary>
		/// Multiply the lower single-precision (32-bit) floating-point element in "a" and "b", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>MULSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_mul_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise OR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>ORPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_or_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Or(a.FP32, b.FP32);

		/// <summary>
		/// Fetch the line of data from memory that contains address "p" to a location in the cache heirarchy specified by the locality hint "i".
		/// </summary>
		/// <remarks><c>PREFETCHNTA m8</c></remarks>
		/// <param name="p"><c>byte {UI8}</c></param>
		/// <param name="i"><c>int {IMM}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_prefetch(byte* p, int i) => System.Runtime.Intrinsics.X86.Sse.Prefetch0((void*)p);

		/// <summary>
		/// Compute the approximate reciprocal of packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.
		/// </summary>
		/// <remarks><c>RCPPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_rcp_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse.Reciprocal(a.FP32);

		/// <summary>
		/// Compute the approximate reciprocal of the lower single-precision (32-bit) floating-point element in "a", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst". The maximum relative error for this approximation is less than 1.5*2^-12.
		/// </summary>
		/// <remarks><c>RCPSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_rcp_ss(__m128 a) => System.Runtime.Intrinsics.X86.Sse.ReciprocalScalar(a.FP32);

		/// <summary>
		/// Compute the approximate reciprocal square root of packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.
		/// </summary>
		/// <remarks><c>RSQRTPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_rsqrt_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrt(a.FP32);

		/// <summary>
		/// Compute the approximate reciprocal square root of the lower single-precision (32-bit) floating-point element in "a", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst". The maximum relative error for this approximation is less than 1.5*2^-12.
		/// </summary>
		/// <remarks><c>RSQRTSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_rsqrt_ss(__m128 a) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrtScalar(a.FP32);

		/// <summary>
		/// Broadcast single-precision (32-bit) floating-point value "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>float {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_set1_ps(float a) => System.Runtime.Intrinsics.Vector128.Create(a);

		/// <summary>
		/// Set packed single-precision (32-bit) floating-point elements in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e3"><c>float {FP32}</c></param>
		/// <param name="e2"><c>float {FP32}</c></param>
		/// <param name="e1"><c>float {FP32}</c></param>
		/// <param name="e0"><c>float {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_setr_ps(float e3, float e2, float e1, float e0) => System.Runtime.Intrinsics.Vector128.Create(e3, e2, e1, e0);

		/// <summary>
		/// Perform a serializing operation on all store-to-memory instructions that were issued prior to this instruction. Guarantees that every store instruction that precedes, in program order, is globally visible before any store instruction which follows the fence in program order.
		/// </summary>
		/// <remarks><c>SFENCE </c></remarks>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_sfence() => System.Runtime.Intrinsics.X86.Sse.StoreFence();

		/// <summary>
		/// Shuffle single-precision (32-bit) floating-point elements in "a" using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>SHUFPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_shuffle_ps(__m128 a, __m128 b, int imm8) => System.Runtime.Intrinsics.X86.Sse.Shuffle(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Compute the square root of packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>SQRTPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_sqrt_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse.Sqrt(a.FP32);

		/// <summary>
		/// Compute the square root of the lower single-precision (32-bit) floating-point element in "a", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>SQRTSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_sqrt_ss(__m128 a) => System.Runtime.Intrinsics.X86.Sse.SqrtScalar(a.FP32);

		/// <summary>
		/// Store 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a" into memory.	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVAPS m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_store_ps(float* mem_addr, __m128 a) => System.Runtime.Intrinsics.X86.Sse.StoreAligned(mem_addr, a.FP32);

		/// <summary>
		/// Store the lower single-precision (32-bit) floating-point element from "a" into memory. "mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVSS m32, xmm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_store_ss(float* mem_addr, __m128 a) => System.Runtime.Intrinsics.X86.Sse.StoreScalar(mem_addr, a.FP32);

		/// <summary>
		/// Store the upper 2 single-precision (32-bit) floating-point elements from "a" into memory.
		/// </summary>
		/// <remarks><c>MOVHPS m64, xmm</c></remarks>
		/// <param name="mem_addr"><c>__m64 {FP32}</c></param>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storeh_pi(__m64* mem_addr, __m128 a) => System.Runtime.Intrinsics.X86.Sse.StoreHigh((float*)mem_addr, a.FP32);

		/// <summary>
		/// Store the lower 2 single-precision (32-bit) floating-point elements from "a" into memory.
		/// </summary>
		/// <remarks><c>MOVLPS m64, xmm</c></remarks>
		/// <param name="mem_addr"><c>__m64 {FP32}</c></param>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storel_pi(__m64* mem_addr, __m128 a) => System.Runtime.Intrinsics.X86.Sse.StoreLow((float*)mem_addr, a.FP32);

		/// <summary>
		/// Store 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a" into memory.	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>MOVUPS m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_storeu_ps(float* mem_addr, __m128 a) => System.Runtime.Intrinsics.X86.Sse.Store(mem_addr, a.FP32);

		/// <summary>
		/// Store 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a" into memory using a non-temporal memory hint.	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVNTPS m128, xmm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_stream_ps(float* mem_addr, __m128 a) => System.Runtime.Intrinsics.X86.Sse.StoreAlignedNonTemporal(mem_addr, a.FP32);

		/// <summary>
		/// Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>SUBPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_sub_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Subtract(a.FP32, b.FP32);

		/// <summary>
		/// Subtract the lower single-precision (32-bit) floating-point element in "b" from the lower single-precision (32-bit) floating-point element in "a", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>SUBSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_sub_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.SubtractScalar(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for equality, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomieq_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than-or-equal, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomige_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedGreaterThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomigt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedGreaterThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than-or-equal, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomile_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedLessThanOrEqual(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomilt_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedLessThan(a.FP32, b.FP32);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for not-equal, and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.
		/// </summary>
		/// <remarks><c>UCOMISS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_ucomineq_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedNotEqual(a.FP32, b.FP32);

		/// <summary>
		/// Unpack and interleave single-precision (32-bit) floating-point elements from the high half "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>UNPCKHPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_unpackhi_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.UnpackHigh(a.FP32, b.FP32);

		/// <summary>
		/// Unpack and interleave single-precision (32-bit) floating-point elements from the low half of "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>UNPCKLPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_unpacklo_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.UnpackLow(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise XOR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>XORPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_xor_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse.Xor(a.FP32, b.FP32);

	}
}
