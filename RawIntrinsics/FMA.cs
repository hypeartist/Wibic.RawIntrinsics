namespace RawIntrinsics
{
	public static unsafe partial class FMA
	{
		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADD132PD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fmadd_pd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADD132PS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fmadd_ps(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and add the intermediate result to the lower element in "c". Store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>VFMADD132SD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fmadd_sd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddScalar(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and add the intermediate result to the lower element in "c". Store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>VFMADD132SS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fmadd_ss(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddScalar(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively add and subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADDSUB132PD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fmaddsub_pd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively add and subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADDSUB132PS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fmaddsub_ps(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUB132PD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fmsub_pd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUB132PS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fmsub_ps(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and subtract the lower element in "c" from the intermediate result. Store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>VFMSUB132SD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fmsub_sd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractScalar(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and subtract the lower element in "c" from the intermediate result. Store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>VFMSUB132SS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fmsub_ss(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractScalar(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively subtract and add packed elements in "c" from/to the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUBADD132PD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fmsubadd_pd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively subtract and add packed elements in "c" from/to the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUBADD132PS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fmsubadd_ps(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMADD132PD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fnmadd_pd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMADD132PS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fnmadd_ps(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and add the negated intermediate result to the lower element in "c". Store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>VFNMADD132SD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fnmadd_sd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegatedScalar(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and add the negated intermediate result to the lower element in "c". Store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>VFNMADD132SS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fnmadd_ss(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegatedScalar(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the negated intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMSUB132PD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fnmsub_pd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the negated intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMSUB132PS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fnmsub_ps(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and subtract the lower element in "c" from the negated intermediate result. Store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".
		/// </summary>
		/// <remarks><c>VFNMSUB132SD xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128d {FP64}</c></param>
		/// <param name="b"><c>__m128d {FP64}</c></param>
		/// <param name="c"><c>__m128d {FP64}</c></param>
		/// <returns><c>__m128d dst {FP64}</c></returns>
		public static __m128d _mm_fnmsub_sd(__m128d a, __m128d b, __m128d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegatedScalar(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and subtract the lower element in "c" from the negated intermediate result. Store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".
		/// </summary>
		/// <remarks><c>VFNMSUB132SS xmm, xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128 {FP32}</c></param>
		/// <param name="b"><c>__m128 {FP32}</c></param>
		/// <param name="c"><c>__m128 {FP32}</c></param>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_fnmsub_ss(__m128 a, __m128 b, __m128 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegatedScalar(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADD132PD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="c"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_fmadd_pd(__m256d a, __m256d b, __m256d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADD132PS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="c"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_fmadd_ps(__m256 a, __m256 b, __m256 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively add and subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADDSUB132PD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="c"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_fmaddsub_pd(__m256d a, __m256d b, __m256d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively add and subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMADDSUB132PS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="c"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_fmaddsub_ps(__m256 a, __m256 b, __m256 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUB132PD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="c"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_fmsub_pd(__m256d a, __m256d b, __m256d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUB132PS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="c"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_fmsub_ps(__m256 a, __m256 b, __m256 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively subtract and add packed elements in "c" from/to the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUBADD132PD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="c"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_fmsubadd_pd(__m256d a, __m256d b, __m256d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively subtract and add packed elements in "c" from/to the intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFMSUBADD132PS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="c"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_fmsubadd_ps(__m256 a, __m256 b, __m256 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMADD132PD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="c"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_fnmadd_pd(__m256d a, __m256d b, __m256d c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate result to packed elements in "c", and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMADD132PS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="c"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_fnmadd_ps(__m256 a, __m256 b, __m256 c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a.FP32, b.FP32, c.FP32);

		/// <summary>
		/// Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the negated intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMSUB132PD ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256d {FP64}</c></param>
		/// <param name="b"><c>__m256d {FP64}</c></param>
		/// <param name="c"><c>__m256d {FP64}</c></param>
		/// <returns><c>__m256d dst {FP64}</c></returns>
		public static __m256d _mm256_fnmsub_pd(__m256d a, __m256d b, __m256d c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a.FP64, b.FP64, c.FP64);

		/// <summary>
		/// Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in "c" from the negated intermediate result, and store the results in "dst".
		/// </summary>
		/// <remarks><c>VFNMSUB132PS ymm, ymm, ymm</c></remarks>
		/// <param name="a"><c>__m256 {FP32}</c></param>
		/// <param name="b"><c>__m256 {FP32}</c></param>
		/// <param name="c"><c>__m256 {FP32}</c></param>
		/// <returns><c>__m256 dst {FP32}</c></returns>
		public static __m256 _mm256_fnmsub_ps(__m256 a, __m256 b, __m256 c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a.FP32, b.FP32, c.FP32);

	}
}
