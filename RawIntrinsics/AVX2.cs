namespace RawIntrinsics
{
	public static unsafe partial class AVX2
	{
		/// <summary>
		/// Blend packed 32-bit integers from "a" and "b" using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPBLENDD xmm, xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_blend_epi32(__m128i a, __m128i b, int imm8) => System.Runtime.Intrinsics.X86.Avx2.Blend(a.UI32, b.UI32, (byte)imm8);

		/// <summary>
		/// Broadcast the low packed 8-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_broadcastb_epi8(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(a.UI8);

		/// <summary>
		/// Broadcast the low packed 32-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_broadcastd_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(a.UI32);

		/// <summary>
		/// Broadcast the low packed 64-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_broadcastq_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(a.UI64);

		/// <summary>
		/// Broadcast the low double-precision (64-bit) floating-point element from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>MOVDDUP xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_broadcastsd_pd(__m128d a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(a.FP64);

		/// <summary>
		/// Broadcast the low single-precision (32-bit) floating-point element from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTSS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_broadcastss_ps(__m128 a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(a.FP32);

		/// <summary>
		/// Broadcast the low packed 16-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_broadcastw_epi16(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(a.UI16);

		/// <summary>
		/// Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDD xmm, vm32x, xmm</c></remarks>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_i32gather_epi32(int* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128((uint*)base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDQ xmm, vm32x, xmm</c></remarks>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_i32gather_epi64(long* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128((ulong*)base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPD xmm, vm32x, xmm</c></remarks>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_i32gather_pd(double* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPS xmm, vm32x, xmm</c></remarks>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_i32gather_ps(float* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQD xmm, vm64x, xmm</c></remarks>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_i64gather_epi32(int* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128((uint*)base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQQ xmm, vm64x, xmm</c></remarks>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_i64gather_epi64(long* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128((ulong*)base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPD xmm, vm64x, xmm</c></remarks>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_i64gather_pd(double* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPS xmm, vm64x, xmm</c></remarks>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_i64gather_ps(float* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDD xmm, vm32x, xmm</c></remarks>
		/// <param name="src"><c>__m128i {UI32}</c></param>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_mask_i32gather_epi32(__m128i src, int* base_addr, __m128i vindex, __m128i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.UI32, (uint*)base_addr, vindex.SI32, mask.UI32, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDQ xmm, vm32x, xmm</c></remarks>
		/// <param name="src"><c>__m128i {UI64}</c></param>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_mask_i32gather_epi64(__m128i src, long* base_addr, __m128i vindex, __m128i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.UI64, (ulong*)base_addr, vindex.SI32, mask.UI64, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPD xmm, vm32x, xmm</c></remarks>
		/// <param name="src"><c>__m128d {FP64}</c></param>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="mask"><c>__m128d {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_mask_i32gather_pd(__m128d src, double* base_addr, __m128i vindex, __m128d mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.FP64, base_addr, vindex.SI32, mask.FP64, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPS xmm, vm32x, xmm</c></remarks>
		/// <param name="src"><c>__m128 {FP32}</c></param>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="mask"><c>__m128 {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_mask_i32gather_ps(__m128 src, float* base_addr, __m128i vindex, __m128 mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.FP32, base_addr, vindex.SI32, mask.FP32, (byte)scale);

		/// <summary>
		/// Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQD xmm, vm64x, xmm</c></remarks>
		/// <param name="src"><c>__m128i {UI32}</c></param>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_mask_i64gather_epi32(__m128i src, int* base_addr, __m128i vindex, __m128i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.UI32, (uint*)base_addr, vindex.SI64, mask.UI32, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQQ xmm, vm64x, xmm</c></remarks>
		/// <param name="src"><c>__m128i {UI64}</c></param>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_mask_i64gather_epi64(__m128i src, long* base_addr, __m128i vindex, __m128i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.UI64, (ulong*)base_addr, vindex.SI64, mask.UI64, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPD xmm, vm64x, xmm</c></remarks>
		/// <param name="src"><c>__m128d {FP64}</c></param>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="mask"><c>__m128d {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_mask_i64gather_pd(__m128d src, double* base_addr, __m128i vindex, __m128d mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.FP64, base_addr, vindex.SI64, mask.FP64, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPS xmm, vm64x, xmm</c></remarks>
		/// <param name="src"><c>__m128 {FP32}</c></param>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m128i {SI64}</c></param>
		/// <param name="mask"><c>__m128 {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_mask_i64gather_ps(__m128 src, float* base_addr, __m128i vindex, __m128 mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.FP32, base_addr, vindex.SI64, mask.FP32, (byte)scale);

		/// <summary>
		/// Load packed 32-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVD xmm, xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>int {UI32}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_maskload_epi32(int* mem_addr, __m128i mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad((uint*)mem_addr, mask.UI32);

		/// <summary>
		/// Load packed 64-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVQ xmm, xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>long {UI64}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_maskload_epi64(long* mem_addr, __m128i mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad((ulong*)mem_addr, mask.UI64);

		/// <summary>
		/// Store packed 32-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVD m128, xmm, xmm</c></remarks>
		/// <param name="mem_addr"><c>int {UI32}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_maskstore_epi32(int* mem_addr, __m128i mask, __m128i a) => System.Runtime.Intrinsics.X86.Avx2.MaskStore((uint*)mem_addr, mask.UI32, a.UI32);

		/// <summary>
		/// Store packed 64-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVQ m128, xmm, xmm</c></remarks>
		/// <param name="mem_addr"><c>long {UI64}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm_maskstore_epi64(long* mem_addr, __m128i mask, __m128i a) => System.Runtime.Intrinsics.X86.Avx2.MaskStore((ulong*)mem_addr, mask.UI64, a.UI64);

		/// <summary>
		/// Shift packed 32-bit integers in "a" left by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLVD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_sllv_epi32(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" left by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLVQ xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="count"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_sllv_epi64(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(a.UI64, count.UI64);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRAVD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_srav_epi32(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmeticVariable(a.SI32, count.UI32);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLVD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_srlv_epi32(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" right by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLVQ xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="count"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_srlv_epi64(__m128i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(a.UI64, count.UI64);

		/// <summary>
		/// Compute the absolute value of packed signed 16-bit integers in "a", and store the unsigned results in "dst".
		/// </summary>
		/// <remarks><c>VPABSW ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_abs_epi16(__m256i a) => System.Runtime.Intrinsics.X86.Avx2.Abs(a.SI16);

		/// <summary>
		/// Compute the absolute value of packed signed 32-bit integers in "a", and store the unsigned results in "dst".
		/// </summary>
		/// <remarks><c>VPABSD ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_abs_epi32(__m256i a) => System.Runtime.Intrinsics.X86.Avx2.Abs(a.SI32);

		/// <summary>
		/// Compute the absolute value of packed signed 8-bit integers in "a", and store the unsigned results in "dst".
		/// </summary>
		/// <remarks><c>VPABSB ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_abs_epi8(__m256i a) => System.Runtime.Intrinsics.X86.Avx2.Abs(a.SI8);

		/// <summary>
		/// Add packed 16-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_add_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Add(a.UI16, b.UI16);

		/// <summary>
		/// Add packed 32-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_add_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Add(a.UI32, b.UI32);

		/// <summary>
		/// Add packed 64-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="b"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_add_epi64(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Add(a.UI64, b.UI64);

		/// <summary>
		/// Add packed 8-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_add_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Add(a.UI8, b.UI8);

		/// <summary>
		/// Add packed 16-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_adds_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Add packed 8-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDSB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI8}</c></param>
		/// <param name="b"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_adds_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(a.SI8, b.SI8);

		/// <summary>
		/// Add packed unsigned 16-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDUSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_adds_epu16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(a.UI16, b.UI16);

		/// <summary>
		/// Add packed unsigned 8-bit integers in "a" and "b" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPADDUSB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_adds_epu8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(a.UI8, b.UI8);

		/// <summary>
		/// Concatenate pairs of 16-byte blocks in "a" and "b" into a 32-byte temporary result, shift the result right by "imm8" bytes, and store the low 16 bytes in "dst".
		/// </summary>
		/// <remarks><c>VPALIGNR ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_alignr_epi8(__m256i a, __m256i b, int imm8) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(a.UI8, b.UI8, (byte)imm8);

		/// <summary>
		/// Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VPAND ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_and_si256(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.And(a.SI8, b.SI8);

		/// <summary>
		/// Compute the bitwise NOT of 256 bits (representing integer data) in "a" and then AND with "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VPANDN ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_andnot_si256(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.AndNot(a.SI8, b.SI8);

		/// <summary>
		/// Average packed unsigned 16-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPAVGW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_avg_epu16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Average(a.UI16, b.UI16);

		/// <summary>
		/// Average packed unsigned 8-bit integers in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPAVGB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_avg_epu8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Average(a.UI8, b.UI8);

		/// <summary>
		/// Blend packed 16-bit integers from "a" and "b" within 128-bit lanes using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPBLENDW ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_blend_epi16(__m256i a, __m256i b, int imm8) => System.Runtime.Intrinsics.X86.Avx2.Blend(a.UI16, b.UI16, (byte)imm8);

		/// <summary>
		/// Blend packed 32-bit integers from "a" and "b" using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPBLENDD ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_blend_epi32(__m256i a, __m256i b, int imm8) => System.Runtime.Intrinsics.X86.Avx2.Blend(a.UI32, b.UI32, (byte)imm8);

		/// <summary>
		/// Blend packed 8-bit integers from "a" and "b" using "mask", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPBLENDVB ymm, ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_blendv_epi8(__m256i a, __m256i b, __m256i mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(a.UI8, b.UI8, mask.UI8);

		/// <summary>
		/// Broadcast the low packed 8-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTB ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_broadcastb_epi8(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(a.UI8);

		/// <summary>
		/// Broadcast the low packed 32-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_broadcastd_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(a.UI32);

		/// <summary>
		/// Broadcast the low packed 64-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTQ ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_broadcastq_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(a.UI64);

		/// <summary>
		/// Broadcast the low double-precision (64-bit) floating-point element from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTSD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_broadcastsd_pd(__m128d a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(a.FP64);

		/// <summary>
		/// Broadcast 128 bits of integer data from "a" to all 128-bit lanes in "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTI128 ymm, m128</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <returns><c>__m256i dst {M128}</c></returns>
		public static __m256i _mm256_broadcastsi128_si256(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256((sbyte*)&a);

		/// <summary>
		/// Broadcast the low single-precision (32-bit) floating-point element from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VBROADCASTSS ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_broadcastss_ps(__m128 a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(a.FP32);

		/// <summary>
		/// Broadcast the low packed 16-bit integer from "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c>VPBROADCASTW ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_broadcastw_epi16(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(a.UI16);

		/// <summary>
		/// Shift 128-bit lanes in "a" left by "imm8" bytes while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLDQ ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {M128}</c></returns>
		public static __m256i _mm256_bslli_epi128(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(a.SI8, (byte)imm8);

		/// <summary>
		/// Shift 128-bit lanes in "a" right by "imm8" bytes while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLDQ ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {M128}</c></returns>
		public static __m256i _mm256_bsrli_epi128(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(a.SI8, (byte)imm8);

		/// <summary>
		/// Compare packed 16-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPEQW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_cmpeq_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(a.UI16, b.UI16);

		/// <summary>
		/// Compare packed 32-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPEQD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_cmpeq_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(a.UI32, b.UI32);

		/// <summary>
		/// Compare packed 64-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPEQQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="b"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_cmpeq_epi64(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(a.UI64, b.UI64);

		/// <summary>
		/// Compare packed 8-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPEQB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_cmpeq_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(a.UI8, b.UI8);

		/// <summary>
		/// Compare packed signed 16-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPGTW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_cmpgt_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(a.SI16, b.SI16);

		/// <summary>
		/// Compare packed signed 32-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPGTD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_cmpgt_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(a.SI32, b.SI32);

		/// <summary>
		/// Compare packed signed 64-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPGTQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI64}</c></param>
		/// <param name="b"><c>__m256i {SI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_cmpgt_epi64(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(a.SI64, b.SI64);

		/// <summary>
		/// Compare packed signed 8-bit integers in "a" and "b" for greater-than, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPCMPGTB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI8}</c></param>
		/// <param name="b"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_cmpgt_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(a.SI8, b.SI8);

		/// <summary>
		/// Sign extend packed 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVSXWD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m256i dst {SI32}</c></returns>
		public static __m256i _mm256_cvtepi16_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(a.SI16);

		/// <summary>
		/// Sign extend packed 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVSXWQ ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m256i dst {SI64}</c></returns>
		public static __m256i _mm256_cvtepi16_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(a.SI16);

		/// <summary>
		/// Sign extend packed 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVSXDQ ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m256i dst {SI64}</c></returns>
		public static __m256i _mm256_cvtepi32_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(a.SI32);

		/// <summary>
		/// Sign extend packed 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVSXBW ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m256i dst {SI16}</c></returns>
		public static __m256i _mm256_cvtepi8_epi16(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int16(a.SI8);

		/// <summary>
		/// Sign extend packed 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVSXBD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m256i dst {SI32}</c></returns>
		public static __m256i _mm256_cvtepi8_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(a.SI8);

		/// <summary>
		/// Sign extend packed 8-bit integers in the low 8 bytes of "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVSXBQ ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m256i dst {SI64}</c></returns>
		public static __m256i _mm256_cvtepi8_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(a.SI8);

		/// <summary>
		/// Zero extend packed unsigned 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVZXWD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_cvtepu16_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(a.UI16);

		/// <summary>
		/// Zero extend packed unsigned 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVZXWQ ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_cvtepu16_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(a.UI16);

		/// <summary>
		/// Zero extend packed unsigned 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVZXDQ ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_cvtepu32_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(a.UI32);

		/// <summary>
		/// Zero extend packed unsigned 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVZXBW ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_cvtepu8_epi16(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int16(a.UI8);

		/// <summary>
		/// Zero extend packed unsigned 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVZXBD ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_cvtepu8_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(a.UI8);

		/// <summary>
		/// Zero extend packed unsigned 8-bit integers in the low 8 byte sof "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPMOVZXBQ ymm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_cvtepu8_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(a.UI8);

		/// <summary>
		/// Extract 128 bits (composed of integer data) from "a", selected with "imm8", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VEXTRACTI128 xmm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm256_extracti128_si256(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(a.SI8, (byte)imm8);

		/// <summary>
		/// Horizontally add adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPHADDW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_hadd_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAdd(a.SI16, b.SI16);

		/// <summary>
		/// Horizontally add adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPHADDD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_hadd_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAdd(a.SI32, b.SI32);

		/// <summary>
		/// Horizontally add adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPHADDSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_hadds_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAddSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Horizontally subtract adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPHSUBW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_hsub_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtract(a.SI16, b.SI16);

		/// <summary>
		/// Horizontally subtract adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPHSUBD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_hsub_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtract(a.SI32, b.SI32);

		/// <summary>
		/// Horizontally subtract adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the signed 16-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPHSUBSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_hsubs_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtractSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDD ymm, vm32x, ymm</c></remarks>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m256i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_i32gather_epi32(int* base_addr, __m256i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256((uint*)base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDQ ymm, vm32x, ymm</c></remarks>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_i32gather_epi64(long* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256((ulong*)base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPD ymm, vm32x, ymm</c></remarks>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_i32gather_pd(double* base_addr, __m128i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPS ymm, vm32x, ymm</c></remarks>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m256i {SI32}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_i32gather_ps(float* base_addr, __m256i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(base_addr, vindex.SI32, (byte)scale);

		/// <summary>
		/// Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQD xmm, vm64y, xmm</c></remarks>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm256_i64gather_epi32(int* base_addr, __m256i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128((uint*)base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQQ ymm, vm64x, ymm</c></remarks>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_i64gather_epi64(long* base_addr, __m256i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256((ulong*)base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPD ymm, vm64x, ymm</c></remarks>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_i64gather_pd(double* base_addr, __m256i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPS xmm, vm64y, xmm</c></remarks>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm256_i64gather_ps(float* base_addr, __m256i vindex, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(base_addr, vindex.SI64, (byte)scale);

		/// <summary>
		/// Copy "a" to "dst", then insert 128 bits (composed of integer data) from "b" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>VINSERTI128 ymm, ymm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {M128}</c></returns>
		public static __m256i _mm256_inserti128_si256(__m256i a, __m128i b, int imm8) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(a.SI8, b.SI8, (byte)imm8);

		/// <summary>
		/// Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers. Horizontally add adjacent pairs of intermediate 32-bit integers, and pack the results in "dst".
		/// </summary>
		/// <remarks><c>VPMADDWD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {SI32}</c></returns>
		public static __m256i _mm256_madd_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.MultiplyAddAdjacent(a.SI16, b.SI16);

		/// <summary>
		/// Vertically multiply each unsigned 8-bit integer from "a" with the corresponding signed 8-bit integer from "b", producing intermediate signed 16-bit integers. Horizontally add adjacent pairs of intermediate signed 16-bit integers, and pack the saturated results in "dst".
		/// </summary>
		/// <remarks><c>VPMADDUBSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {SI16}</c></returns>
		public static __m256i _mm256_maddubs_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.MultiplyAddAdjacent(a.UI8, b.SI8);

		/// <summary>
		/// Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDD ymm, vm32x, ymm</c></remarks>
		/// <param name="src"><c>__m256i {UI32}</c></param>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m256i {SI32}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_mask_i32gather_epi32(__m256i src, int* base_addr, __m256i vindex, __m256i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(src.UI32, (uint*)base_addr, vindex.SI32, mask.UI32, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERDQ ymm, vm32x, ymm</c></remarks>
		/// <param name="src"><c>__m256i {UI64}</c></param>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_mask_i32gather_epi64(__m256i src, long* base_addr, __m128i vindex, __m256i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(src.UI64, (ulong*)base_addr, vindex.SI32, mask.UI64, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPD ymm, vm32x, ymm</c></remarks>
		/// <param name="src"><c>__m256d {FP64}</c></param>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m128i {SI32}</c></param>
		/// <param name="mask"><c>__m256d {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_mask_i32gather_pd(__m256d src, double* base_addr, __m128i vindex, __m256d mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(src.FP64, base_addr, vindex.SI32, mask.FP64, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERDPS ymm, vm32x, ymm</c></remarks>
		/// <param name="src"><c>__m256 {FP32}</c></param>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m256i {SI32}</c></param>
		/// <param name="mask"><c>__m256 {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_mask_i32gather_ps(__m256 src, float* base_addr, __m256i vindex, __m256 mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(src.FP32, base_addr, vindex.SI32, mask.FP32, (byte)scale);

		/// <summary>
		/// Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQD xmm, vm64y, xmm</c></remarks>
		/// <param name="src"><c>__m128i {UI32}</c></param>
		/// <param name="base_addr"><c>int {UI32}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="mask"><c>__m128i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm256_mask_i64gather_epi32(__m128i src, int* base_addr, __m256i vindex, __m128i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.UI32, (uint*)base_addr, vindex.SI64, mask.UI32, (byte)scale);

		/// <summary>
		/// Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VPGATHERQQ ymm, vm64x, ymm</c></remarks>
		/// <param name="src"><c>__m256i {UI64}</c></param>
		/// <param name="base_addr"><c>long {UI64}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_mask_i64gather_epi64(__m256i src, long* base_addr, __m256i vindex, __m256i mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(src.UI64, (ulong*)base_addr, vindex.SI64, mask.UI64, (byte)scale);

		/// <summary>
		/// Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPD ymm, vm64x, ymm</c></remarks>
		/// <param name="src"><c>__m256d {FP64}</c></param>
		/// <param name="base_addr"><c>double {FP64}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="mask"><c>__m256d {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_mask_i64gather_pd(__m256d src, double* base_addr, __m256i vindex, __m256d mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(src.FP64, base_addr, vindex.SI64, mask.FP64, (byte)scale);

		/// <summary>
		/// Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.
		/// </summary>
		/// <remarks><c>VGATHERQPS xmm, vm64y, xmm</c></remarks>
		/// <param name="src"><c>__m128 {FP32}</c></param>
		/// <param name="base_addr"><c>float {FP32}</c></param>
		/// <param name="vindex"><c>__m256i {SI64}</c></param>
		/// <param name="mask"><c>__m128 {MASK}</c></param>
		/// <param name="scale"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm256_mask_i64gather_ps(__m128 src, float* base_addr, __m256i vindex, __m128 mask, int scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(src.FP32, base_addr, vindex.SI64, mask.FP32, (byte)scale);

		/// <summary>
		/// Load packed 32-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVD ymm, ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>int {UI32}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_maskload_epi32(int* mem_addr, __m256i mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad((uint*)mem_addr, mask.UI32);

		/// <summary>
		/// Load packed 64-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVQ ymm, ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>long {UI64}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_maskload_epi64(long* mem_addr, __m256i mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad((ulong*)mem_addr, mask.UI64);

		/// <summary>
		/// Store packed 32-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVD m256, ymm, ymm</c></remarks>
		/// <param name="mem_addr"><c>int {UI32}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_maskstore_epi32(int* mem_addr, __m256i mask, __m256i a) => System.Runtime.Intrinsics.X86.Avx2.MaskStore((uint*)mem_addr, mask.UI32, a.UI32);

		/// <summary>
		/// Store packed 64-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit is not set in the corresponding element).
		/// </summary>
		/// <remarks><c>VPMASKMOVQ m256, ymm, ymm</c></remarks>
		/// <param name="mem_addr"><c>long {UI64}</c></param>
		/// <param name="mask"><c>__m256i {MASK}</c></param>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <returns><c>void  {}</c></returns>
		public static void _mm256_maskstore_epi64(long* mem_addr, __m256i mask, __m256i a) => System.Runtime.Intrinsics.X86.Avx2.MaskStore((ulong*)mem_addr, mask.UI64, a.UI64);

		/// <summary>
		/// Compare packed signed 16-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VPMAXSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_max_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Max(a.SI16, b.SI16);

		/// <summary>
		/// Compare packed signed 32-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VPMAXSD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_max_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Max(a.SI32, b.SI32);

		/// <summary>
		/// Compare packed signed 8-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VPMAXSB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI8}</c></param>
		/// <param name="b"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_max_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Max(a.SI8, b.SI8);

		/// <summary>
		/// Compare packed unsigned 16-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VPMAXUW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_max_epu16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Max(a.UI16, b.UI16);

		/// <summary>
		/// Compare packed unsigned 32-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VPMAXUD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_max_epu32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Max(a.UI32, b.UI32);

		/// <summary>
		/// Compare packed unsigned 8-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>VPMAXUB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_max_epu8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Max(a.UI8, b.UI8);

		/// <summary>
		/// Compare packed signed 16-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VPMINSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_min_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Min(a.SI16, b.SI16);

		/// <summary>
		/// Compare packed signed 32-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VPMINSD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_min_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Min(a.SI32, b.SI32);

		/// <summary>
		/// Compare packed signed 8-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VPMINSB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI8}</c></param>
		/// <param name="b"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_min_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Min(a.SI8, b.SI8);

		/// <summary>
		/// Compare packed unsigned 16-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VPMINUW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_min_epu16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Min(a.UI16, b.UI16);

		/// <summary>
		/// Compare packed unsigned 32-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VPMINUD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_min_epu32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Min(a.UI32, b.UI32);

		/// <summary>
		/// Compare packed unsigned 8-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>VPMINUB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_min_epu8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Min(a.UI8, b.UI8);

		/// <summary>
		/// Create mask from the most significant bit of each 8-bit element in "a", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VPMOVMSKB r32, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm256_movemask_epi8(__m256i a) => System.Runtime.Intrinsics.X86.Avx2.MoveMask(a.UI8);

		/// <summary>
		/// Compute the sum of absolute differences (SADs) of quadruplets of unsigned 8-bit integers in "a" compared to those in "b", and store the 16-bit results in "dst".	Eight SADs are performed for each 128-bit lane using one quadruplet from "b" and eight quadruplets from "a". One quadruplet is selected from "b" starting at on the offset specified in "imm8". Eight quadruplets are formed from sequential 8-bit integers selected from "a" starting at the offset specified in "imm8".
		/// </summary>
		/// <remarks><c>VMPSADBW ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_mpsadbw_epu8(__m256i a, __m256i b, int imm8) => System.Runtime.Intrinsics.X86.Avx2.MultipleSumAbsoluteDifferences(a.UI8, b.UI8, (byte)imm8);

		/// <summary>
		/// Multiply the low signed 32-bit integers from each packed 64-bit element in "a" and "b", and store the signed 64-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPMULDQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {SI64}</c></returns>
		public static __m256i _mm256_mul_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Multiply(a.SI32, b.SI32);

		/// <summary>
		/// Multiply the low unsigned 32-bit integers from each packed 64-bit element in "a" and "b", and store the unsigned 64-bit results in "dst".
		/// </summary>
		/// <remarks><c>VPMULUDQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_mul_epu32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Multiply(a.UI32, b.UI32);

		/// <summary>
		/// Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the high 16 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>VPMULHW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_mulhi_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHigh(a.SI16, b.SI16);

		/// <summary>
		/// Multiply the packed unsigned 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the high 16 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>VPMULHUW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_mulhi_epu16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHigh(a.UI16, b.UI16);

		/// <summary>
		/// Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers. Truncate each intermediate integer to the 18 most significant bits, round by adding 1, and store bits [16:1] to "dst".
		/// </summary>
		/// <remarks><c>VPMULHRSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_mulhrs_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHighRoundScale(a.SI16, b.SI16);

		/// <summary>
		/// Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the low 16 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>VPMULLW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_mullo_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(a.SI16, b.SI16);

		/// <summary>
		/// Multiply the packed signed 32-bit integers in "a" and "b", producing intermediate 64-bit integers, and store the low 32 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>VPMULLD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_mullo_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(a.SI32, b.SI32);

		/// <summary>
		/// Compute the bitwise OR of 256 bits (representing integer data) in "a" and "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VPOR ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_or_si256(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Or(a.SI8, b.SI8);

		/// <summary>
		/// Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using signed saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPACKSSWB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {SI8}</c></returns>
		public static __m256i _mm256_packs_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.PackSignedSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using signed saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPACKSSDW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {SI16}</c></returns>
		public static __m256i _mm256_packs_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.PackSignedSaturate(a.SI32, b.SI32);

		/// <summary>
		/// Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using unsigned saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPACKUSWB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_packus_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.PackUnsignedSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using unsigned saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPACKUSDW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_packus_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.PackUnsignedSaturate(a.SI32, b.SI32);

		/// <summary>
		/// Shuffle 128-bits (composed of integer data) selected by "imm8" from "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERM2I128 ymm, ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_permute2x128_si256(__m256i a, __m256i b, int imm8) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(a.SI8, b.SI8, (byte)imm8);

		/// <summary>
		/// Shuffle 64-bit integers in "a" across lanes using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMQ ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_permute4x64_epi64(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(a.UI64, (byte)imm8);

		/// <summary>
		/// Shuffle double-precision (64-bit) floating-point elements in "a" across lanes using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMPD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_permute4x64_pd(__m256d a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(a.FP64, (byte)imm8);

		/// <summary>
		/// Shuffle 32-bit integers in "a" across lanes using the corresponding index in "idx", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPERMD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="idx"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_permutevar8x32_epi32(__m256i a, __m256i idx) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(a.UI32, idx.UI32);

		/// <summary>
		/// Shuffle single-precision (32-bit) floating-point elements in "a" across lanes using the corresponding index in "idx".
		/// </summary>
		/// <remarks><c>VPERMPS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="idx"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_permutevar8x32_ps(__m256 a, __m256i idx) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(a.FP32, idx.SI32);

		/// <summary>
		/// Compute the absolute differences of packed unsigned 8-bit integers in "a" and "b", then horizontally sum each consecutive 8 differences to produce four unsigned 16-bit integers, and pack these unsigned 16-bit integers in the low 16 bits of 64-bit elements in "dst".
		/// </summary>
		/// <remarks><c>VPSADBW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_sad_epu8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.SumAbsoluteDifferences(a.UI8, b.UI8);

		/// <summary>
		/// Shuffle 32-bit integers in "a" within 128-bit lanes using the control in "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSHUFD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_shuffle_epi32(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(a.UI32, (byte)imm8);

		/// <summary>
		/// Shuffle 8-bit integers in "a" within 128-bit lanes according to shuffle control mask in the corresponding 8-bit element of "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSHUFB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_shuffle_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(a.UI8, b.UI8);

		/// <summary>
		/// Shuffle 16-bit integers in the high 64 bits of 128-bit lanes of "a" using the control in "imm8". Store the results in the high 64 bits of 128-bit lanes of "dst", with the low 64 bits of 128-bit lanes being copied from from "a" to "dst".
		/// </summary>
		/// <remarks><c>VPSHUFHW ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_shufflehi_epi16(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShuffleHigh(a.UI16, (byte)imm8);

		/// <summary>
		/// Shuffle 16-bit integers in the low 64 bits of 128-bit lanes of "a" using the control in "imm8". Store the results in the low 64 bits of 128-bit lanes of "dst", with the high 64 bits of 128-bit lanes being copied from from "a" to "dst".
		/// </summary>
		/// <remarks><c>VPSHUFLW ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_shufflelo_epi16(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShuffleLow(a.UI16, (byte)imm8);

		/// <summary>
		/// Negate packed signed 16-bit integers in "a" when the corresponding signed 16-bit integer in "b" is negative, and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.
		/// </summary>
		/// <remarks><c>VPSIGNW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_sign_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Sign(a.SI16, b.SI16);

		/// <summary>
		/// Negate packed signed 32-bit integers in "a" when the corresponding signed 32-bit integer in "b" is negative, and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.
		/// </summary>
		/// <remarks><c>VPSIGND ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="b"><c>__m256i {SI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_sign_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Sign(a.SI32, b.SI32);

		/// <summary>
		/// Negate packed signed 8-bit integers in "a" when the corresponding signed 8-bit integer in "b" is negative, and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.
		/// </summary>
		/// <remarks><c>VPSIGNB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI8}</c></param>
		/// <param name="b"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_sign_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Sign(a.SI8, b.SI8);

		/// <summary>
		/// Shift packed 16-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLW ymm, ymm, xmm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="count"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_sll_epi16(__m256i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(a.UI16, count.UI16);

		/// <summary>
		/// Shift packed 32-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLD ymm, ymm, xmm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_sll_epi32(__m256i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLQ ymm, ymm, xmm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="count"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_sll_epi64(__m256i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(a.UI64, count.UI64);

		/// <summary>
		/// Shift packed 16-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLW ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_slli_epi16(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(a.UI16, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_slli_epi32(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(a.UI32, (byte)imm8);

		/// <summary>
		/// Shift packed 64-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLQ ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_slli_epi64(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(a.UI64, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" left by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLVD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="count"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_sllv_epi32(__m256i a, __m256i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" left by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSLLVQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="count"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_sllv_epi64(__m256i a, __m256i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(a.UI64, count.UI64);

		/// <summary>
		/// Shift packed 16-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRAW ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_srai_epi16(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(a.SI16, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRAD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_srai_epi32(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(a.SI32, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count" while shifting in sign bits, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRAVD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI32}</c></param>
		/// <param name="count"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_srav_epi32(__m256i a, __m256i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmeticVariable(a.SI32, count.UI32);

		/// <summary>
		/// Shift packed 16-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLW ymm, ymm, xmm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="count"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_srl_epi16(__m256i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(a.UI16, count.UI16);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLD ymm, ymm, xmm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="count"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_srl_epi32(__m256i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLQ ymm, ymm, xmm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="count"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_srl_epi64(__m256i a, __m128i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(a.UI64, count.UI64);

		/// <summary>
		/// Shift packed 16-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLW ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_srli_epi16(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(a.UI16, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLD ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_srli_epi32(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(a.UI32, (byte)imm8);

		/// <summary>
		/// Shift packed 64-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLQ ymm, ymm, imm8</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_srli_epi64(__m256i a, int imm8) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(a.UI64, (byte)imm8);

		/// <summary>
		/// Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLVD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="count"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_srlv_epi32(__m256i a, __m256i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(a.UI32, count.UI32);

		/// <summary>
		/// Shift packed 64-bit integers in "a" right by the amount specified by the corresponding element in "count" while shifting in zeros, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSRLVQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="count"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_srlv_epi64(__m256i a, __m256i count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(a.UI64, count.UI64);

		/// <summary>
		/// Load 256-bits of integer data from memory into "dst" using a non-temporal memory hint.	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>VMOVNTDQA ymm, m256</c></remarks>
		/// <param name="mem_addr"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_stream_load_si256(__m256i* mem_addr) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal((sbyte*)mem_addr);

		/// <summary>
		/// Subtract packed 16-bit integers in "b" from packed 16-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_sub_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Subtract(a.UI16, b.UI16);

		/// <summary>
		/// Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_sub_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Subtract(a.UI32, b.UI32);

		/// <summary>
		/// Subtract packed 64-bit integers in "b" from packed 64-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="b"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_sub_epi64(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Subtract(a.UI64, b.UI64);

		/// <summary>
		/// Subtract packed 8-bit integers in "b" from packed 8-bit integers in "a", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_sub_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Subtract(a.UI8, b.UI8);

		/// <summary>
		/// Subtract packed signed 16-bit integers in "b" from packed 16-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI16}</c></param>
		/// <param name="b"><c>__m256i {SI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_subs_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(a.SI16, b.SI16);

		/// <summary>
		/// Subtract packed signed 8-bit integers in "b" from packed 8-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBSB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {SI8}</c></param>
		/// <param name="b"><c>__m256i {SI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_subs_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(a.SI8, b.SI8);

		/// <summary>
		/// Subtract packed unsigned 16-bit integers in "b" from packed unsigned 16-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBUSW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_subs_epu16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(a.UI16, b.UI16);

		/// <summary>
		/// Subtract packed unsigned 8-bit integers in "b" from packed unsigned 8-bit integers in "a" using saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPSUBUSB ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_subs_epu8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(a.UI8, b.UI8);

		/// <summary>
		/// Unpack and interleave 16-bit integers from the high half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKHWD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_unpackhi_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(a.UI16, b.UI16);

		/// <summary>
		/// Unpack and interleave 32-bit integers from the high half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKHDQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_unpackhi_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(a.UI32, b.UI32);

		/// <summary>
		/// Unpack and interleave 64-bit integers from the high half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKHQDQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="b"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_unpackhi_epi64(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(a.UI64, b.UI64);

		/// <summary>
		/// Unpack and interleave 8-bit integers from the high half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKHBW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_unpackhi_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(a.UI8, b.UI8);

		/// <summary>
		/// Unpack and interleave 16-bit integers from the low half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKLWD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI16}</c></param>
		/// <param name="b"><c>__m256i {UI16}</c></param>
		/// <returns><c>__m256i dst {UI16}</c></returns>
		public static __m256i _mm256_unpacklo_epi16(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(a.UI16, b.UI16);

		/// <summary>
		/// Unpack and interleave 32-bit integers from the low half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKLDQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI32}</c></param>
		/// <param name="b"><c>__m256i {UI32}</c></param>
		/// <returns><c>__m256i dst {UI32}</c></returns>
		public static __m256i _mm256_unpacklo_epi32(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(a.UI32, b.UI32);

		/// <summary>
		/// Unpack and interleave 64-bit integers from the low half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKLQDQ ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI64}</c></param>
		/// <param name="b"><c>__m256i {UI64}</c></param>
		/// <returns><c>__m256i dst {UI64}</c></returns>
		public static __m256i _mm256_unpacklo_epi64(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(a.UI64, b.UI64);

		/// <summary>
		/// Unpack and interleave 8-bit integers from the low half of each 128-bit lane in "a" and "b", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VPUNPCKLBW ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {UI8}</c></param>
		/// <param name="b"><c>__m256i {UI8}</c></param>
		/// <returns><c>__m256i dst {UI8}</c></returns>
		public static __m256i _mm256_unpacklo_epi8(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(a.UI8, b.UI8);

		/// <summary>
		/// Compute the bitwise XOR of 256 bits (representing integer data) in "a" and "b", and store the result in "dst".
		/// </summary>
		/// <remarks><c>VPXOR ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256i {M256}</c></param>
		/// <param name="b"><c>__m256i {M256}</c></param>
		/// <returns><c>__m256i dst {M256}</c></returns>
		public static __m256i _mm256_xor_si256(__m256i a, __m256i b) => System.Runtime.Intrinsics.X86.Avx2.Xor(a.SI8, b.SI8);

	}
}
