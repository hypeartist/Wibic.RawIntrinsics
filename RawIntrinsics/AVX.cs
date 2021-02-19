namespace RawIntrinsics
{
	public static unsafe partial class AVX
	{
		/// <summary>
		/// Broadcast a single-precision (32-bit) floating-point element from memory to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTSS xmm, m32</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_broadcast_ss(float* mem_addr) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector128(mem_addr);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison operand specified by "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCMPPD xmm, xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmp_pd(__m128d a, __m128d b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Compare(a.FP64, b.FP64, (System.Runtime.Intrinsics.X86.FloatComparisonMode)imm8);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison operand specified by "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCMPPS xmm, xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmp_ps(__m128 a, __m128 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Compare(a.FP32, b.FP32, (System.Runtime.Intrinsics.X86.FloatComparisonMode)imm8);

		/// <summary>
		/// Compare the lower double-precision (64-bit) floating-point element in "a" and "b" based on the comparison operand specified by "imm8", store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>VCMPSD xmm, xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_cmp_sd(__m128d a, __m128d b, int imm8) => System.Runtime.Intrinsics.X86.Avx.CompareScalar(a.FP64, b.FP64, (System.Runtime.Intrinsics.X86.FloatComparisonMode)imm8);

		/// <summary>
		/// Compare the lower single-precision (32-bit) floating-point element in "a" and "b" based on the comparison operand specified by "imm8", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>VCMPSS xmm, xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_cmp_ss(__m128 a, __m128 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.CompareScalar(a.FP32, b.FP32, (System.Runtime.Intrinsics.X86.FloatComparisonMode)imm8);

		/// <summary>
		/// Load packed double-precision (64-bit) floating-point elements from memory into "dst" using "mask" (elements are zeroed out when the high bit of the corresponding element is not set).
		/// </summary>
		/// <remarks><c>VMASKMOVPD xmm, xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_maskload_pd(double* mem_addr, __m128i mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(mem_addr, mask.FP64);

		/// <summary>
		/// Load packed single-precision (32-bit) floating-point elements from memory into "dst" using "mask" (elements are zeroed out when the high bit of the corresponding element is not set).
		/// </summary>
		/// <remarks><c>VMASKMOVPS xmm, xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_maskload_ps(float* mem_addr, __m128i mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(mem_addr, mask.FP32);

		/// <summary>
		/// Store packed double-precision (64-bit) floating-point elements from "a" into memory using "mask".
		/// </summary>
		/// <remarks><c>VMASKMOVPD m128, xmm, xmm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_maskstore_pd(double* mem_addr, __m128i mask, __m128d a) => System.Runtime.Intrinsics.X86.Avx.MaskStore(mem_addr, mask.FP64, a.FP64);

		/// <summary>
		/// Store packed single-precision (32-bit) floating-point elements from "a" into memory using "mask".
		/// </summary>
		/// <remarks><c>VMASKMOVPS m128, xmm, xmm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_maskstore_ps(float* mem_addr, __m128i mask, __m128 a) => System.Runtime.Intrinsics.X86.Avx.MaskStore(mem_addr, mask.FP32, a.FP32);

		/// <summary>
		/// Shuffle double-precision (64-bit) floating-point elements in "a" using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_permute_pd(__m128d a, int imm8) => System.Runtime.Intrinsics.X86.Avx.Permute(a.FP64, (byte)imm8);

		/// <summary>
		/// Shuffle single-precision (32-bit) floating-point elements in "a" using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_permute_ps(__m128 a, int imm8) => System.Runtime.Intrinsics.X86.Avx.Permute(a.FP32, (byte)imm8);

		/// <summary>
		/// Shuffle double-precision (64-bit) floating-point elements in "a" using the control in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_permutevar_pd(__m128d a, __m128i b) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(a.FP64, b.SI64);

		/// <summary>
		/// Shuffle single-precision (32-bit) floating-point elements in "a" using the control in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_permutevar_ps(__m128 a, __m128i b) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(a.FP32, b.SI32);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing double-precision (64-bit) floating-point elements) in "a" and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "CF" value.
		/// </summary>
		/// <remarks><c>VTESTPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm_testc_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Avx.TestC(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing single-precision (32-bit) floating-point elements) in "a" and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "CF" value.
		/// </summary>
		/// <remarks><c>VTESTPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm_testc_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Avx.TestC(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing double-precision (64-bit) floating-point elements) in "a" and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.
		/// </summary>
		/// <remarks><c>VTESTPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm_testnzc_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing single-precision (32-bit) floating-point elements) in "a" and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.
		/// </summary>
		/// <remarks><c>VTESTPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm_testnzc_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing double-precision (64-bit) floating-point elements) in "a" and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "ZF" value.
		/// </summary>
		/// <remarks><c>VTESTPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm_testz_pd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Avx.TestZ(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing single-precision (32-bit) floating-point elements) in "a" and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "ZF" value.
		/// </summary>
		/// <remarks><c>VTESTPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm_testz_ps(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Avx.TestZ(a.FP32, b.FP32);

		/// <summary>
		/// Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VADDPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_add_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Add(a.FP64, b.FP64);

		/// <summary>
		/// Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VADDPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_add_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Add(a.FP32, b.FP32);

		/// <summary>
		/// Alternatively add and subtract packed double-precision (64-bit) floating-point elements in "a" to/from packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VADDSUBPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_addsub_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.AddSubtract(a.FP64, b.FP64);

		/// <summary>
		/// Alternatively add and subtract packed single-precision (32-bit) floating-point elements in "a" to/from packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VADDSUBPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_addsub_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.AddSubtract(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VANDPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_and_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.And(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VANDPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_and_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.And(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise NOT of packed double-precision (64-bit) floating-point elements in "a" and then AND with "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VANDNPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_andnot_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.AndNot(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise NOT of packed single-precision (32-bit) floating-point elements in "a" and then AND with "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VANDNPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_andnot_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.AndNot(a.FP32, b.FP32);

		/// <summary>
		/// Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VBLENDPD ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_blend_pd(__m256d a, __m256d b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Blend(a.FP64, b.FP64, (byte)imm8);

		/// <summary>
		/// Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VBLENDPS ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_blend_ps(__m256 a, __m256 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Blend(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using "mask", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VBLENDVPD ymm, ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="mask"><c>__m256d {MASK}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_blendv_pd(__m256d a, __m256d b, __m256d mask) => System.Runtime.Intrinsics.X86.Avx.BlendVariable(a.FP64, b.FP64, mask.FP64);

		/// <summary>
		/// Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using "mask", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VBLENDVPS ymm, ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="mask"><c>__m256 {MASK}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_blendv_ps(__m256 a, __m256 b, __m256 mask) => System.Runtime.Intrinsics.X86.Avx.BlendVariable(a.FP32, b.FP32, mask.FP32);

		/// <summary>
		/// Broadcast 128 bits from memory (composed of 2 packed double-precision (64-bit) floating-point elements) to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTF128 ymm, m128</c></remarks>
		/// <param name="mem_addr"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_broadcast_pd(__m128d* mem_addr) => System.Runtime.Intrinsics.X86.Avx.BroadcastVector128ToVector256((double*)mem_addr);

		/// <summary>
		/// Broadcast 128 bits from memory (composed of 4 packed single-precision (32-bit) floating-point elements) to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTF128 ymm, m128</c></remarks>
		/// <param name="mem_addr"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_broadcast_ps(__m128* mem_addr) => System.Runtime.Intrinsics.X86.Avx.BroadcastVector128ToVector256((float*)mem_addr);

		/// <summary>
		/// Broadcast a double-precision (64-bit) floating-point element from memory to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTSD ymm, m64</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_broadcast_sd(double* mem_addr) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector256(mem_addr);

		/// <summary>
		/// Broadcast a single-precision (32-bit) floating-point element from memory to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTSS ymm, m32</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_broadcast_ss(float* mem_addr) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector256(mem_addr);

		/// <summary>
		/// Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store the results as packed double-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>VROUNDPD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_ceil_pd(__m256d a) => System.Runtime.Intrinsics.X86.Avx.Ceiling(a.FP64);

		/// <summary>
		/// Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store the results as packed single-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>VROUNDPS ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_ceil_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.Ceiling(a.FP32);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison operand specified by "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCMPPD ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_cmp_pd(__m256d a, __m256d b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Compare(a.FP64, b.FP64, (System.Runtime.Intrinsics.X86.FloatComparisonMode)imm8);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison operand specified by "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCMPPS ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_cmp_ps(__m256 a, __m256 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Compare(a.FP32, b.FP32, (System.Runtime.Intrinsics.X86.FloatComparisonMode)imm8);

		/// <summary>
		/// Convert packed signed 32-bit integers in "a" to packed double-precision (64-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTDQ2PD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_cvtepi32_pd(__m128i a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Double(a.SI32);

		/// <summary>
		/// Convert packed signed 32-bit integers in "a" to packed single-precision (32-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTDQ2PS ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_cvtepi32_ps(__m256i a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Single(a.SI32);

		/// <summary>
		/// Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTPD2DQ xmm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm256_cvtpd_epi32(__m256d a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Int32(a.FP64);

		/// <summary>
		/// Convert packed double-precision (64-bit) floating-point elements in "a" to packed single-precision (32-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTPD2PS xmm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm256_cvtpd_ps(__m256d a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Single(a.FP64);

		/// <summary>
		/// Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTPS2DQ ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_cvtps_epi32(__m256 a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Int32(a.FP32);

		/// <summary>
		/// Convert packed single-precision (32-bit) floating-point elements in "a" to packed double-precision (64-bit) floating-point elements, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTPS2PD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_cvtps_pd(__m128 a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Double(a.FP32);

		/// <summary>
		/// Copy the lower 32-bit integer in "a" to "dst".
		/// </summary>
		/// <remarks><c>VMOVD r32, xmm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm256_cvtsi256_si32(__m256i a) => (int)System.Runtime.Intrinsics.X86.Avx2.ConvertToUInt32(a.UI32);

		/// <summary>
		/// Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers with truncation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTTPD2DQ xmm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm256_cvttpd_epi32(__m256d a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Int32WithTruncation(a.FP64);

		/// <summary>
		/// Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers with truncation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VCVTTPS2DQ ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_cvttps_epi32(__m256 a) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Int32WithTruncation(a.FP32);

		/// <summary>
		/// Divide packed double-precision (64-bit) floating-point elements in "a" by packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VDIVPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_div_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Divide(a.FP64, b.FP64);

		/// <summary>
		/// Divide packed single-precision (32-bit) floating-point elements in "a" by packed elements in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VDIVPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_div_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Divide(a.FP32, b.FP32);

		/// <summary>
		/// Conditionally multiply the packed single-precision (32-bit) floating-point elements in "a" and "b" using the high 4 bits in "imm8", sum the four products, and conditionally store the sum in "dst" using the low 4 bits of "imm8".
		/// </summary>
		/// <remarks><c>VDPPS ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_dp_ps(__m256 a, __m256 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.DotProduct(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Extract 128 bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a", selected with "imm8", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VEXTRACTF128 xmm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm256_extractf128_pd(__m256d a, int imm8) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(a.FP64, (byte)imm8);

		/// <summary>
		/// Extract 128 bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a", selected with "imm8", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VEXTRACTF128 xmm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm256_extractf128_ps(__m256 a, int imm8) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(a.FP32, (byte)imm8);

		/// <summary>
		/// Extract 128 bits (composed of integer data) from "a", selected with "imm8", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VEXTRACTF128 xmm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm256_extractf128_si256(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(a.UI8, (byte)imm8);

		/// <summary>
		/// Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store the results as packed double-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>VROUNDPD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_floor_pd(__m256d a) => System.Runtime.Intrinsics.X86.Avx.Floor(a.FP64);

		/// <summary>
		/// Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store the results as packed single-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>VROUNDPS ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_floor_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.Floor(a.FP32);

		/// <summary>
		/// Horizontally add adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>VHADDPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_hadd_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.HorizontalAdd(a.FP64, b.FP64);

		/// <summary>
		/// Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>VHADDPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_hadd_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.HorizontalAdd(a.FP32, b.FP32);

		/// <summary>
		/// Horizontally subtract adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>VHSUBPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_hsub_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.HorizontalSubtract(a.FP64, b.FP64);

		/// <summary>
		/// Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack the results in "dst".
		/// </summary>
		/// <remarks><c>VHSUBPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_hsub_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.HorizontalSubtract(a.FP32, b.FP32);

		/// <summary>
		/// Copy "a" to "dst", then insert 128 bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "b" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>VINSERTF128 ymm, ymm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_insertf128_pd(__m256d a, __m128d b, int imm8) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(a.FP64, b.FP64, (byte)imm8);

		/// <summary>
		/// Copy "a" to "dst", then insert 128 bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "b" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>VINSERTF128 ymm, ymm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_insertf128_ps(__m256 a, __m128 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Copy "a" to "dst", then insert 128 bits from "b" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>VINSERTF128 ymm, ymm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {M128}</c></returns>
		public static __m256i _mm256_insertf128_si256(__m256i a, __m128i b, int imm8) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(a.UI8, b.UI8, (byte)imm8);

		/// <summary>
		/// Load 256-bits of integer data from unaligned memory into "dst". This intrinsic may perform better than "_mm256_loadu_si256" when the data crosses a cache line boundary.
		/// </summary>
		/// <remarks><c>VLDDQU ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_lddqu_si256(__m256i* mem_addr) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256((sbyte*)mem_addr);

		/// <summary>
		/// Load 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from memory into "dst".	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVAPD ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_load_pd(double* mem_addr) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(mem_addr);

		/// <summary>
		/// Load 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from memory into "dst".	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVAPS ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_load_ps(float* mem_addr) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(mem_addr);

		/// <summary>
		/// Load 256-bits of integer data from memory into "dst".	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVDQA ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_load_si256(__m256i* mem_addr) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256((sbyte*)mem_addr);

		/// <summary>
		/// Load 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from memory into "dst".	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>VMOVUPD ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_loadu_pd(double* mem_addr) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(mem_addr);

		/// <summary>
		/// Load 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from memory into "dst".	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>VMOVUPS ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_loadu_ps(float* mem_addr) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(mem_addr);

		/// <summary>
		/// Load 256-bits of integer data from memory into "dst".	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>VMOVDQU ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_loadu_si256(__m256i* mem_addr) => System.Runtime.Intrinsics.X86.Avx.LoadVector256((sbyte*)mem_addr);

		/// <summary>
		/// Load packed double-precision (64-bit) floating-point elements from memory into "dst" using "mask" (elements are zeroed out when the high bit of the corresponding element is not set).
		/// </summary>
		/// <remarks><c>VMASKMOVPD ymm, ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_maskload_pd(double* mem_addr, __m256i mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(mem_addr, mask.FP64);

		/// <summary>
		/// Load packed single-precision (32-bit) floating-point elements from memory into "dst" using "mask" (elements are zeroed out when the high bit of the corresponding element is not set).
		/// </summary>
		/// <remarks><c>VMASKMOVPS ymm, ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_maskload_ps(float* mem_addr, __m256i mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(mem_addr, mask.FP32);

		/// <summary>
		/// Store packed double-precision (64-bit) floating-point elements from "a" into memory using "mask".
		/// </summary>
		/// <remarks><c>VMASKMOVPD m256, ymm, ymm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_maskstore_pd(double* mem_addr, __m256i mask, __m256d a) => System.Runtime.Intrinsics.X86.Avx.MaskStore(mem_addr, mask.FP64, a.FP64);

		/// <summary>
		/// Store packed single-precision (32-bit) floating-point elements from "a" into memory using "mask".
		/// </summary>
		/// <remarks><c>VMASKMOVPS m256, ymm, ymm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_maskstore_ps(float* mem_addr, __m256i mask, __m256 a) => System.Runtime.Intrinsics.X86.Avx.MaskStore(mem_addr, mask.FP32, a.FP32);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VMAXPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_max_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Max(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VMAXPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_max_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Max(a.FP32, b.FP32);

		/// <summary>
		/// Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VMINPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_min_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Min(a.FP64, b.FP64);

		/// <summary>
		/// Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VMINPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_min_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Min(a.FP32, b.FP32);

		/// <summary>
		/// Duplicate even-indexed double-precision (64-bit) floating-point elements from "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VMOVDDUP ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_movedup_pd(__m256d a) => System.Runtime.Intrinsics.X86.Avx.DuplicateEvenIndexed(a.FP64);

		/// <summary>
		/// Duplicate odd-indexed single-precision (32-bit) floating-point elements from "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VMOVSHDUP ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_movehdup_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.DuplicateOddIndexed(a.FP32);

		/// <summary>
		/// Duplicate even-indexed single-precision (32-bit) floating-point elements from "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VMOVSLDUP ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_moveldup_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.DuplicateEvenIndexed(a.FP32);

		/// <summary>
		/// Set each bit of mask "dst" based on the most significant bit of the corresponding packed double-precision (64-bit) floating-point element in "a".
		/// </summary>
		/// <remarks><c>VMOVMSKPD r32, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm256_movemask_pd(__m256d a) => System.Runtime.Intrinsics.X86.Avx.MoveMask(a.FP64);

		/// <summary>
		/// Set each bit of mask "dst" based on the most significant bit of the corresponding packed single-precision (32-bit) floating-point element in "a".
		/// </summary>
		/// <remarks><c>VMOVMSKPS r32, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm256_movemask_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.MoveMask(a.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VMULPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_mul_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Multiply(a.FP64, b.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VMULPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_mul_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Multiply(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise OR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VORPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_or_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Or(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise OR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VORPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_or_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Or(a.FP32, b.FP32);

		/// <summary>
		/// Shuffle double-precision (64-bit) floating-point elements in "a" within 128-bit lanes using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_permute_pd(__m256d a, int imm8) => System.Runtime.Intrinsics.X86.Avx.Permute(a.FP64, (byte)imm8);

		/// <summary>
		/// Shuffle single-precision (32-bit) floating-point elements in "a" within 128-bit lanes using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPS ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_permute_ps(__m256 a, int imm8) => System.Runtime.Intrinsics.X86.Avx.Permute(a.FP32, (byte)imm8);

		/// <summary>
		/// Shuffle 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) selected by "imm8" from "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERM2F128 ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_permute2f128_pd(__m256d a, __m256d b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(a.FP64, b.FP64, (byte)imm8);

		/// <summary>
		/// Shuffle 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) selected by "imm8" from "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERM2F128 ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_permute2f128_ps(__m256 a, __m256 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Shuffle 128-bits (composed of integer data) selected by "imm8" from "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERM2F128 ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_permute2f128_si256(__m256i a, __m256i b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(a.UI8, b.UI8, (byte)imm8);

		/// <summary>
		/// Shuffle double-precision (64-bit) floating-point elements in "a" within 128-bit lanes using the control in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_permutevar_pd(__m256d a, __m256i b) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(a.FP64, b.SI64);

		/// <summary>
		/// Shuffle single-precision (32-bit) floating-point elements in "a" within 128-bit lanes using the control in "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMILPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_permutevar_ps(__m256 a, __m256i b) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(a.FP32, b.SI32);

		/// <summary>
		/// Compute the approximate reciprocal of packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.
		/// </summary>
		/// <remarks><c>VRCPPS ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_rcp_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.Reciprocal(a.FP32);

		/// <summary>
		/// Round the packed double-precision (64-bit) floating-point elements in "a" using the "rounding" parameter, and store the results as packed double-precision floating-point elements in "dst".	[round_note]
		/// </summary>
		/// <remarks><c>VROUNDPD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="rounding"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_round_pd(__m256d a, int rounding) => System.Runtime.Intrinsics.X86.Avx.RoundCurrentDirection(a.FP64);

		/// <summary>
		/// Round the packed single-precision (32-bit) floating-point elements in "a" using the "rounding" parameter, and store the results as packed single-precision floating-point elements in "dst".	[round_note]
		/// </summary>
		/// <remarks><c>VROUNDPS ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="rounding"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_round_ps(__m256 a, int rounding) => System.Runtime.Intrinsics.X86.Avx.RoundCurrentDirection(a.FP32);

		/// <summary>
		/// Compute the approximate reciprocal square root of packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.
		/// </summary>
		/// <remarks><c>VRSQRTPS ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_rsqrt_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.ReciprocalSqrt(a.FP32);

		/// <summary>
		/// Broadcast 16-bit integer "a" to all all elements of "dst". This intrinsic may generate the "vpbroadcastw".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>short {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_set1_epi16(short a) => System.Runtime.Intrinsics.Vector256.Create((ushort)a);

		/// <summary>
		/// Broadcast 32-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastd".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>int {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_set1_epi32(int a) => System.Runtime.Intrinsics.Vector256.Create((uint)a);

		/// <summary>
		/// Broadcast 64-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastq".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>long {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_set1_epi64x(long a) => System.Runtime.Intrinsics.Vector256.Create((ulong)a);

		/// <summary>
		/// Broadcast 8-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastb".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>byte {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_set1_epi8(byte a) => System.Runtime.Intrinsics.Vector256.Create(a);

		/// <summary>
		/// Broadcast double-precision (64-bit) floating-point value "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>double {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_set1_pd(double a) => System.Runtime.Intrinsics.Vector256.Create(a);

		/// <summary>
		/// Broadcast single-precision (32-bit) floating-point value "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>float {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_set1_ps(float a) => System.Runtime.Intrinsics.Vector256.Create(a);

		/// <summary>
		/// Set packed 16-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e15"><c>short {UI16}</c></param>
		/// <param name="e14"><c>short {UI16}</c></param>
		/// <param name="e13"><c>short {UI16}</c></param>
		/// <param name="e12"><c>short {UI16}</c></param>
		/// <param name="e11"><c>short {UI16}</c></param>
		/// <param name="e10"><c>short {UI16}</c></param>
		/// <param name="e9"><c>short {UI16}</c></param>
		/// <param name="e8"><c>short {UI16}</c></param>
		/// <param name="e7"><c>short {UI16}</c></param>
		/// <param name="e6"><c>short {UI16}</c></param>
		/// <param name="e5"><c>short {UI16}</c></param>
		/// <param name="e4"><c>short {UI16}</c></param>
		/// <param name="e3"><c>short {UI16}</c></param>
		/// <param name="e2"><c>short {UI16}</c></param>
		/// <param name="e1"><c>short {UI16}</c></param>
		/// <param name="e0"><c>short {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_setr_epi16(short e15, short e14, short e13, short e12, short e11, short e10, short e9, short e8, short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) => System.Runtime.Intrinsics.Vector256.Create((ushort)e15, (ushort)e14, (ushort)e13, (ushort)e12, (ushort)e11, (ushort)e10, (ushort)e9, (ushort)e8, (ushort)e7, (ushort)e6, (ushort)e5, (ushort)e4, (ushort)e3, (ushort)e2, (ushort)e1, (ushort)e0);

		/// <summary>
		/// Set packed 32-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e7"><c>int {UI32}</c></param>
		/// <param name="e6"><c>int {UI32}</c></param>
		/// <param name="e5"><c>int {UI32}</c></param>
		/// <param name="e4"><c>int {UI32}</c></param>
		/// <param name="e3"><c>int {UI32}</c></param>
		/// <param name="e2"><c>int {UI32}</c></param>
		/// <param name="e1"><c>int {UI32}</c></param>
		/// <param name="e0"><c>int {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_setr_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0) => System.Runtime.Intrinsics.Vector256.Create((uint)e7, (uint)e6, (uint)e5, (uint)e4, (uint)e3, (uint)e2, (uint)e1, (uint)e0);

		/// <summary>
		/// Set packed 64-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e3"><c>long {UI64}</c></param>
		/// <param name="e2"><c>long {UI64}</c></param>
		/// <param name="e1"><c>long {UI64}</c></param>
		/// <param name="e0"><c>long {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_setr_epi64x(long e3, long e2, long e1, long e0) => System.Runtime.Intrinsics.Vector256.Create((ulong)e3, (ulong)e2, (ulong)e1, (ulong)e0);

		/// <summary>
		/// Set packed 8-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e31"><c>byte {UI8}</c></param>
		/// <param name="e30"><c>byte {UI8}</c></param>
		/// <param name="e29"><c>byte {UI8}</c></param>
		/// <param name="e28"><c>byte {UI8}</c></param>
		/// <param name="e27"><c>byte {UI8}</c></param>
		/// <param name="e26"><c>byte {UI8}</c></param>
		/// <param name="e25"><c>byte {UI8}</c></param>
		/// <param name="e24"><c>byte {UI8}</c></param>
		/// <param name="e23"><c>byte {UI8}</c></param>
		/// <param name="e22"><c>byte {UI8}</c></param>
		/// <param name="e21"><c>byte {UI8}</c></param>
		/// <param name="e20"><c>byte {UI8}</c></param>
		/// <param name="e19"><c>byte {UI8}</c></param>
		/// <param name="e18"><c>byte {UI8}</c></param>
		/// <param name="e17"><c>byte {UI8}</c></param>
		/// <param name="e16"><c>byte {UI8}</c></param>
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
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_setr_epi8(byte e31, byte e30, byte e29, byte e28, byte e27, byte e26, byte e25, byte e24, byte e23, byte e22, byte e21, byte e20, byte e19, byte e18, byte e17, byte e16, byte e15, byte e14, byte e13, byte e12, byte e11, byte e10, byte e9, byte e8, byte e7, byte e6, byte e5, byte e4, byte e3, byte e2, byte e1, byte e0) => System.Runtime.Intrinsics.Vector256.Create(e31, e30, e29, e28, e27, e26, e25, e24, e23, e22, e21, e20, e19, e18, e17, e16, e15, e14, e13, e12, e11, e10, e9, e8, e7, e6, e5, e4, e3, e2, e1, e0);

		/// <summary>
		/// Set packed __m256 vector "dst" with the supplied values.
		/// </summary>
		/// <remarks><c>VINSERTF128 ymm, ymm, xmm, imm8</c></remarks>
		/// <param name="lo"><c>__m128 {FP32}</c></param>
		/// <param name="hi"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_setr_m128(__m128 lo, __m128 hi) => System.Runtime.Intrinsics.Vector256.Create(lo.FP32, hi.FP32);

		/// <summary>
		/// Set packed __m256d vector "dst" with the supplied values.
		/// </summary>
		/// <remarks><c>VINSERTF128 ymm, ymm, xmm, imm8</c></remarks>
		/// <param name="lo"><c>__m128d {FP64}</c></param>
		/// <param name="hi"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_setr_m128d(__m128d lo, __m128d hi) => System.Runtime.Intrinsics.Vector256.Create(lo.FP64, hi.FP64);

		/// <summary>
		/// Set packed __m256i vector "dst" with the supplied values.
		/// </summary>
		/// <remarks><c>VINSERTF128 ymm, ymm, xmm, imm8</c></remarks>
		/// <param name="lo"><c>__m128i {M128}</c></param>
		/// <param name="hi"><c>__m128i {M128}</c></param>
		/// <returns><c>__m256i dst {M128}</c></returns>
		public static __m256i _mm256_setr_m128i(__m128i lo, __m128i hi) => System.Runtime.Intrinsics.Vector256.Create(lo.SI32, hi.SI32);

		/// <summary>
		/// Set packed double-precision (64-bit) floating-point elements in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e3"><c>double {FP64}</c></param>
		/// <param name="e2"><c>double {FP64}</c></param>
		/// <param name="e1"><c>double {FP64}</c></param>
		/// <param name="e0"><c>double {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_setr_pd(double e3, double e2, double e1, double e0) => System.Runtime.Intrinsics.Vector256.Create(e3, e2, e1, e0);

		/// <summary>
		/// Set packed single-precision (32-bit) floating-point elements in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e7"><c>float {FP32}</c></param>
		/// <param name="e6"><c>float {FP32}</c></param>
		/// <param name="e5"><c>float {FP32}</c></param>
		/// <param name="e4"><c>float {FP32}</c></param>
		/// <param name="e3"><c>float {FP32}</c></param>
		/// <param name="e2"><c>float {FP32}</c></param>
		/// <param name="e1"><c>float {FP32}</c></param>
		/// <param name="e0"><c>float {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_setr_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0) => System.Runtime.Intrinsics.Vector256.Create(e7, e6, e5, e4, e3, e2, e1, e0);

		/// <summary>
		/// Shuffle double-precision (64-bit) floating-point elements within 128-bit lanes using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VSHUFPD ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_shuffle_pd(__m256d a, __m256d b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Shuffle(a.FP64, b.FP64, (byte)imm8);

		/// <summary>
		/// Shuffle single-precision (32-bit) floating-point elements in "a" within 128-bit lanes using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VSHUFPS ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_shuffle_ps(__m256 a, __m256 b, int imm8) => System.Runtime.Intrinsics.X86.Avx.Shuffle(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Compute the square root of packed double-precision (64-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VSQRTPD ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_sqrt_pd(__m256d a) => System.Runtime.Intrinsics.X86.Avx.Sqrt(a.FP64);

		/// <summary>
		/// Compute the square root of packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VSQRTPS ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_sqrt_ps(__m256 a) => System.Runtime.Intrinsics.X86.Avx.Sqrt(a.FP32);

		/// <summary>
		/// Store 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from "a" into memory.	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVAPD m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_store_pd(double* mem_addr, __m256d a) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(mem_addr, a.FP64);

		/// <summary>
		/// Store 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from "a" into memory.	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVAPS m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_store_ps(float* mem_addr, __m256 a) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(mem_addr, a.FP32);

		/// <summary>
		/// Store 256-bits of integer data from "a" into memory.	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVDQA m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>__m256i {M256}</c></param>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_store_si256(__m256i* mem_addr, __m256i a) => System.Runtime.Intrinsics.X86.Avx.StoreAligned((sbyte*)mem_addr, a.SI8);

		/// <summary>
		/// Store 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from "a" into memory.	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>VMOVUPD m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_storeu_pd(double* mem_addr, __m256d a) => System.Runtime.Intrinsics.X86.Avx.Store(mem_addr, a.FP64);

		/// <summary>
		/// Store 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from "a" into memory.	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>VMOVUPS m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_storeu_ps(float* mem_addr, __m256 a) => System.Runtime.Intrinsics.X86.Avx.Store(mem_addr, a.FP32);

		/// <summary>
		/// Store 256-bits of integer data from "a" into memory.	"mem_addr" does not need to be aligned on any particular boundary.
		/// </summary>
		/// <remarks><c>VMOVDQU m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>__m256i {M256}</c></param>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_storeu_si256(__m256i* mem_addr, __m256i a) => System.Runtime.Intrinsics.X86.Avx.Store((sbyte*)mem_addr, a.SI8);

		/// <summary>
		/// Store 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from "a" into memory using a non-temporal memory hint.	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVNTPD m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>double {FP64}</c></param>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_stream_pd(double* mem_addr, __m256d a) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(mem_addr, a.FP64);

		/// <summary>
		/// Store 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from "a" into memory using a non-temporal memory hint.	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVNTPS m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>float {FP32}</c></param>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_stream_ps(float* mem_addr, __m256 a) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(mem_addr, a.FP32);

		/// <summary>
		/// Store 256-bits of integer data from "a" into memory using a non-temporal memory hint.	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVNTDQ m256, ymm</c></remarks>
		/// <param name="mem_addr"><c>__m256i {M256}</c></param>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_stream_si256(__m256i* mem_addr, __m256i a) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal((sbyte*)mem_addr, a.SI8);

		/// <summary>
		/// Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VSUBPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_sub_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Subtract(a.FP64, b.FP64);

		/// <summary>
		/// Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit) floating-point elements in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VSUBPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_sub_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Subtract(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing double-precision (64-bit) floating-point elements) in "a" and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "CF" value.
		/// </summary>
		/// <remarks><c>VTESTPD ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm256_testc_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.TestC(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing single-precision (32-bit) floating-point elements) in "a" and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "CF" value.
		/// </summary>
		/// <remarks><c>VTESTPS ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm256_testc_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.TestC(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to 1 if the result is zero, otherwise set "CF" to 0. Return the "CF" value.
		/// </summary>
		/// <remarks><c>VPTEST ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm256_testc_si256(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx.TestC(a.UI8, b.UI8);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing double-precision (64-bit) floating-point elements) in "a" and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.
		/// </summary>
		/// <remarks><c>VTESTPD ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm256_testnzc_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing single-precision (32-bit) floating-point elements) in "a" and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.
		/// </summary>
		/// <remarks><c>VTESTPS ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm256_testnzc_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to 1 if the result is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.
		/// </summary>
		/// <remarks><c>VPTEST ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm256_testnzc_si256(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(a.UI8, b.UI8);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing double-precision (64-bit) floating-point elements) in "a" and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "ZF" value.
		/// </summary>
		/// <remarks><c>VTESTPD ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm256_testz_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.TestZ(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing single-precision (32-bit) floating-point elements) in "a" and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate value is zero, otherwise set "CF" to 0. Return the "ZF" value.
		/// </summary>
		/// <remarks><c>VTESTPS ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm256_testz_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.TestZ(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to 1 if the result is zero, otherwise set "CF" to 0. Return the "ZF" value.
		/// </summary>
		/// <remarks><c>VPTEST ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm256_testz_si256(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx.TestZ(a.UI8, b.UI8);

		/// <summary>
		/// Unpack and interleave double-precision (64-bit) floating-point elements from the high half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VUNPCKHPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_unpackhi_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.UnpackHigh(a.FP64, b.FP64);

		/// <summary>
		/// Unpack and interleave single-precision (32-bit) floating-point elements from the high half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VUNPCKHPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_unpackhi_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.UnpackHigh(a.FP32, b.FP32);

		/// <summary>
		/// Unpack and interleave double-precision (64-bit) floating-point elements from the low half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VUNPCKLPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_unpacklo_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.UnpackLow(a.FP64, b.FP64);

		/// <summary>
		/// Unpack and interleave single-precision (32-bit) floating-point elements from the low half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VUNPCKLPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_unpacklo_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.UnpackLow(a.FP32, b.FP32);

		/// <summary>
		/// Compute the bitwise XOR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VXORPD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_xor_pd(__m256d a, __m256d b) => System.Runtime.Intrinsics.X86.Avx.Xor(a.FP64, b.FP64);

		/// <summary>
		/// Compute the bitwise XOR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VXORPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_xor_ps(__m256 a, __m256 b) => System.Runtime.Intrinsics.X86.Avx.Xor(a.FP32, b.FP32);

	}
}
