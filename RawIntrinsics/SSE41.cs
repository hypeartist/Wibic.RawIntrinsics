namespace RawIntrinsics
{
	public static unsafe partial class SSE41
	{
		/// <summary>
		/// Blend packed 16-bit integers from "a" and "b" using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PBLENDW xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_blend_epi16(__m128i a, __m128i b, int imm8) => System.Runtime.Intrinsics.X86.Sse41.Blend(a.UI16, b.UI16, (byte)imm8);

		/// <summary>
		/// Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>BLENDPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_blend_pd(__m128d a, __m128d b, int imm8) => System.Runtime.Intrinsics.X86.Sse41.Blend(a.FP64, b.FP64, (byte)imm8);

		/// <summary>
		/// Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using control mask "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>BLENDPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_blend_ps(__m128 a, __m128 b, int imm8) => System.Runtime.Intrinsics.X86.Sse41.Blend(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Blend packed 8-bit integers from "a" and "b" using "mask", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PBLENDVB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <param name="mask"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_blendv_epi8(__m128i a, __m128i b, __m128i mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(a.UI8, b.UI8, mask.UI8);

		/// <summary>
		/// Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using "mask", and store the results in "dst".
		/// </summary>
		/// <remarks><c>BLENDVPD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="mask"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_blendv_pd(__m128d a, __m128d b, __m128d mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(a.FP64, b.FP64, mask.FP64);

		/// <summary>
		/// Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using "mask", and store the results in "dst".
		/// </summary>
		/// <remarks><c>BLENDVPS xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="mask"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_blendv_ps(__m128 a, __m128 b, __m128 mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(a.FP32, b.FP32, mask.FP32);

		/// <summary>
		/// Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store the results as packed double-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>ROUNDPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_ceil_pd(__m128d a) => System.Runtime.Intrinsics.X86.Sse41.Ceiling(a.FP64);

		/// <summary>
		/// Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store the results as packed single-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>ROUNDPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_ceil_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse41.Ceiling(a.FP32);

		/// <summary>
		/// Round the lower double-precision (64-bit) floating-point element in "b" up to an integer value, store the result as a double-precision floating-point element in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>ROUNDSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_ceil_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(a.FP64);

		/// <summary>
		/// Round the lower single-precision (32-bit) floating-point element in "b" up to an integer value, store the result as a single-precision floating-point element in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>ROUNDSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_ceil_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(a.FP32);

		/// <summary>
		/// Compare packed 64-bit integers in "a" and "b" for equality, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCMPEQQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="b"><c>__m128i {UI64}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_cmpeq_epi64(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.CompareEqual(a.UI64, b.UI64);

		/// <summary>
		/// Sign extend packed 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVSXWD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI32}</c></returns>
		public static __m128i _mm_cvtepi16_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(a.SI16);

		/// <summary>
		/// Sign extend packed 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVSXWQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI16}</c></param>
		/// <returns><c>__m128i dst {SI64}</c></returns>
		public static __m128i _mm_cvtepi16_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(a.SI16);

		/// <summary>
		/// Sign extend packed 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVSXDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {SI64}</c></returns>
		public static __m128i _mm_cvtepi32_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(a.SI32);

		/// <summary>
		/// Sign extend packed 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVSXBW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {SI16}</c></returns>
		public static __m128i _mm_cvtepi8_epi16(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int16(a.SI8);

		/// <summary>
		/// Sign extend packed 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVSXBD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {SI32}</c></returns>
		public static __m128i _mm_cvtepi8_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(a.SI8);

		/// <summary>
		/// Sign extend packed 8-bit integers in the low 8 bytes of "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVSXBQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {SI64}</c></returns>
		public static __m128i _mm_cvtepi8_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(a.SI8);

		/// <summary>
		/// Zero extend packed unsigned 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVZXWD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cvtepu16_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(a.UI16);

		/// <summary>
		/// Zero extend packed unsigned 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVZXWQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_cvtepu16_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(a.UI16);

		/// <summary>
		/// Zero extend packed unsigned 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVZXDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_cvtepu32_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(a.UI32);

		/// <summary>
		/// Zero extend packed unsigned 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVZXBW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_cvtepu8_epi16(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int16(a.UI8);

		/// <summary>
		/// Zero extend packed unsigned 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVZXBD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_cvtepu8_epi32(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(a.UI8);

		/// <summary>
		/// Zero extend packed unsigned 8-bit integers in the low 8 byte sof "a" to packed 64-bit integers, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PMOVZXBQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_cvtepu8_epi64(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(a.UI8);

		/// <summary>
		/// Conditionally multiply the packed double-precision (64-bit) floating-point elements in "a" and "b" using the high 4 bits in "imm8", sum the four products, and conditionally store the sum in "dst" using the low 4 bits of "imm8".
		/// </summary>
		/// <remarks><c>DPPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_dp_pd(__m128d a, __m128d b, int imm8) => System.Runtime.Intrinsics.X86.Sse41.DotProduct(a.FP64, b.FP64, (byte)imm8);

		/// <summary>
		/// Conditionally multiply the packed single-precision (32-bit) floating-point elements in "a" and "b" using the high 4 bits in "imm8", sum the four products, and conditionally store the sum in "dst" using the low 4 bits of "imm8".
		/// </summary>
		/// <remarks><c>DPPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_dp_ps(__m128 a, __m128 b, int imm8) => System.Runtime.Intrinsics.X86.Sse41.DotProduct(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Extract a 32-bit integer from "a", selected with "imm8", and store the result in "dst".
		/// </summary>
		/// <remarks><c>PEXTRD r32, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_extract_epi32(__m128i a, int imm8) => (int)System.Runtime.Intrinsics.X86.Sse41.Extract(a.UI32, (byte)imm8);

		/// <summary>
		/// Extract a 64-bit integer from "a", selected with "imm8", and store the result in "dst".
		/// </summary>
		/// <remarks><c>PEXTRQ r64, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_extract_epi64(__m128i a, int imm8) => (long)System.Runtime.Intrinsics.X86.Sse41.X64.Extract(a.UI64, (byte)imm8);

		/// <summary>
		/// Extract an 8-bit integer from "a", selected with "imm8", and store the result in the lower element of "dst".
		/// </summary>
		/// <remarks><c>PEXTRB r32, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>int dst {UI8}</c></returns>
		public static int _mm_extract_epi8(__m128i a, int imm8) => (int)System.Runtime.Intrinsics.X86.Sse41.Extract(a.UI8, (byte)imm8);

		/// <summary>
		/// Extract a single-precision (32-bit) floating-point element from "a", selected with "imm8", and store the result in "dst".
		/// </summary>
		/// <remarks><c>EXTRACTPS r32, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_extract_ps(__m128 a, int imm8) => (int)System.Runtime.Intrinsics.X86.Sse41.Extract(a.FP32, (byte)imm8);

		/// <summary>
		/// Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store the results as packed double-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>ROUNDPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_floor_pd(__m128d a) => System.Runtime.Intrinsics.X86.Sse41.Floor(a.FP64);

		/// <summary>
		/// Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store the results as packed single-precision floating-point elements in "dst".
		/// </summary>
		/// <remarks><c>ROUNDPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_floor_ps(__m128 a) => System.Runtime.Intrinsics.X86.Sse41.Floor(a.FP32);

		/// <summary>
		/// Round the lower double-precision (64-bit) floating-point element in "b" down to an integer value, store the result as a double-precision floating-point element in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>ROUNDSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_floor_sd(__m128d a, __m128d b) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(a.FP64);

		/// <summary>
		/// Round the lower single-precision (32-bit) floating-point element in "b" down to an integer value, store the result as a single-precision floating-point element in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>ROUNDSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_floor_ss(__m128 a, __m128 b) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(a.FP32);

		/// <summary>
		/// Copy "a" to "dst", and insert the 32-bit integer "i" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>PINSRD xmm, r32, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="i"><c>int {UI32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_insert_epi32(__m128i a, int i, int imm8) => System.Runtime.Intrinsics.X86.Sse41.Insert(a.UI32, (uint)i, (byte)imm8);

		/// <summary>
		/// Copy "a" to "dst", and insert the 64-bit integer "i" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>PINSRQ xmm, r64, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI64}</c></param>
		/// <param name="i"><c>long {UI64}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI64}</c></returns>
		public static __m128i _mm_insert_epi64(__m128i a, long i, int imm8) => System.Runtime.Intrinsics.X86.Sse41.X64.Insert(a.UI64, (ulong)i, (byte)imm8);

		/// <summary>
		/// Copy "a" to "dst", and insert the lower 8-bit integer from "i" into "dst" at the location specified by "imm8".
		/// </summary>
		/// <remarks><c>PINSRB xmm, r32, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="i"><c>int {UI8}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_insert_epi8(__m128i a, int i, int imm8) => System.Runtime.Intrinsics.X86.Sse41.Insert(a.UI8, (byte)i, (byte)imm8);

		/// <summary>
		/// Copy "a" to "tmp", then insert a single-precision (32-bit) floating-point element from "b" into "tmp" using the control in "imm8". Store "tmp" to "dst" using the mask in "imm8" (elements are zeroed out when the corresponding bit is set).
		/// </summary>
		/// <remarks><c>INSERTPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_insert_ps(__m128 a, __m128 b, int imm8) => System.Runtime.Intrinsics.X86.Sse41.Insert(a.FP32, b.FP32, (byte)imm8);

		/// <summary>
		/// Compare packed signed 32-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>PMAXSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_max_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Max(a.SI32, b.SI32);

		/// <summary>
		/// Compare packed signed 8-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>PMAXSB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_max_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Max(a.SI8, b.SI8);

		/// <summary>
		/// Compare packed unsigned 16-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>PMAXUW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_max_epu16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Max(a.UI16, b.UI16);

		/// <summary>
		/// Compare packed unsigned 32-bit integers in "a" and "b", and store packed maximum values in "dst".
		/// </summary>
		/// <remarks><c>PMAXUD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_max_epu32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Max(a.UI32, b.UI32);

		/// <summary>
		/// Compare packed signed 32-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>PMINSD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_min_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Min(a.SI32, b.SI32);

		/// <summary>
		/// Compare packed signed 8-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>PMINSB xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI8}</c></param>
		/// <param name="b"><c>__m128i {SI8}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_min_epi8(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Min(a.SI8, b.SI8);

		/// <summary>
		/// Compare packed unsigned 16-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>PMINUW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <param name="b"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_min_epu16(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Min(a.UI16, b.UI16);

		/// <summary>
		/// Compare packed unsigned 32-bit integers in "a" and "b", and store packed minimum values in "dst".
		/// </summary>
		/// <remarks><c>PMINUD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_min_epu32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Min(a.UI32, b.UI32);

		/// <summary>
		/// Horizontally compute the minimum amongst the packed unsigned 16-bit integers in "a", store the minimum and index in "dst", and zero the remaining bits in "dst".
		/// </summary>
		/// <remarks><c>PHMINPOSUW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI16}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_minpos_epu16(__m128i a) => System.Runtime.Intrinsics.X86.Sse41.MinHorizontal(a.UI16);

		/// <summary>
		/// Compute the sum of absolute differences (SADs) of quadruplets of unsigned 8-bit integers in "a" compared to those in "b", and store the 16-bit results in "dst".	Eight SADs are performed using one quadruplet from "b" and eight quadruplets from "a". One quadruplet is selected from "b" starting at on the offset specified in "imm8". Eight quadruplets are formed from sequential 8-bit integers selected from "a" starting at the offset specified in "imm8".
		/// </summary>
		/// <remarks><c>MPSADBW xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {UI8}</c></param>
		/// <param name="b"><c>__m128i {UI8}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {UI8}</c></returns>
		public static __m128i _mm_mpsadbw_epu8(__m128i a, __m128i b, int imm8) => System.Runtime.Intrinsics.X86.Sse41.MultipleSumAbsoluteDifferences(a.UI8, b.UI8, (byte)imm8);

		/// <summary>
		/// Multiply the low signed 32-bit integers from each packed 64-bit element in "a" and "b", and store the signed 64-bit results in "dst".
		/// </summary>
		/// <remarks><c>PMULDQ xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {SI64}</c></returns>
		public static __m128i _mm_mul_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.Multiply(a.SI32, b.SI32);

		/// <summary>
		/// Multiply the packed 32-bit integers in "a" and "b", producing intermediate 64-bit integers, and store the low 32 bits of the intermediate integers in "dst".
		/// </summary>
		/// <remarks><c>PMULLD xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {UI32}</c></param>
		/// <param name="b"><c>__m128i {UI32}</c></param>
		/// <returns><c>__m128i dst {UI32}</c></returns>
		public static __m128i _mm_mullo_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.MultiplyLow(a.UI32, b.UI32);

		/// <summary>
		/// Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using unsigned saturation, and store the results in "dst".
		/// </summary>
		/// <remarks><c>PACKUSDW xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {SI32}</c></param>
		/// <param name="b"><c>__m128i {SI32}</c></param>
		/// <returns><c>__m128i dst {UI16}</c></returns>
		public static __m128i _mm_packus_epi32(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.PackUnsignedSaturate(a.SI32, b.SI32);

		/// <summary>
		/// Round the packed double-precision (64-bit) floating-point elements in "a" using the "rounding" parameter, and store the results as packed double-precision floating-point elements in "dst".	[round_note]
		/// </summary>
		/// <remarks><c>ROUNDPD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="rounding"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_round_pd(__m128d a, int rounding) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestInteger(a.FP64);

		/// <summary>
		/// Round the packed single-precision (32-bit) floating-point elements in "a" using the "rounding" parameter, and store the results as packed single-precision floating-point elements in "dst".	[round_note]
		/// </summary>
		/// <remarks><c>ROUNDPS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="rounding"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_round_ps(__m128 a, int rounding) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestInteger(a.FP32);

		/// <summary>
		/// Round the lower double-precision (64-bit) floating-point element in "b" using the "rounding" parameter, store the result as a double-precision floating-point element in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".	[round_note]
		/// </summary>
		/// <remarks><c>ROUNDSD xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="rounding"><c>int {IMM}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_round_sd(__m128d a, __m128d b, int rounding) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(a.FP64);

		/// <summary>
		/// Round the lower single-precision (32-bit) floating-point element in "b" using the "rounding" parameter, store the result as a single-precision floating-point element in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".	[round_note]
		/// </summary>
		/// <remarks><c>ROUNDSS xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="rounding"><c>int {IMM}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_round_ss(__m128 a, __m128 b, int rounding) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(a.FP32);

		/// <summary>
		/// Load 128-bits of integer data from memory into "dst" using a non-temporal memory hint.	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.
		/// </summary>
		/// <remarks><c>MOVNTDQA xmm, m128</c></remarks>
		/// <param name="mem_addr"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_stream_load_si128(__m128i* mem_addr) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal((sbyte*)mem_addr);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to 1 if the result is zero, otherwise set "CF" to 0. Return the "CF" value.
		/// </summary>
		/// <remarks><c>PTEST xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_testc_si128(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.TestC(a.SI8, b.SI8);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to 1 if the result is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.
		/// </summary>
		/// <remarks><c>PTEST xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <returns><c>bool dst {UI8}</c></returns>
		public static bool _mm_testnzc_si128(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.TestNotZAndNotC(a.SI8, b.SI8);

		/// <summary>
		/// Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to 1 if the result is zero, otherwise set "CF" to 0. Return the "ZF" value.
		/// </summary>
		/// <remarks><c>PTEST xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <returns><c>bool k {UI8}</c></returns>
		public static bool _mm_testz_si128(__m128i a, __m128i b) => System.Runtime.Intrinsics.X86.Sse41.TestZ(a.SI8, b.SI8);

	}
}
