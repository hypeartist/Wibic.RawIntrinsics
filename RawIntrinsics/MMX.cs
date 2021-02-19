namespace RawIntrinsics
{
	public static unsafe partial class MMX
	{
		/// <summary>
		/// Broadcast 16-bit integer "a" to all all elements of "dst".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>short {UI16}</c></param>
		/// <returns><c>__m64 dst {FP32}</c></returns>
		public static __m64 _mm_set1_pi16(short a) => System.Runtime.Intrinsics.Vector64.Create((ushort)a);

		/// <summary>
		/// Broadcast 32-bit integer "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>int {UI32}</c></param>
		/// <returns><c>__m64 dst {FP32}</c></returns>
		public static __m64 _mm_set1_pi32(int a) => System.Runtime.Intrinsics.Vector64.Create((uint)a);

		/// <summary>
		/// Broadcast 8-bit integer "a" to all elements of "dst".
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="a"><c>byte {UI8}</c></param>
		/// <returns><c>__m64 dst {FP32}</c></returns>
		public static __m64 _mm_set1_pi8(byte a) => System.Runtime.Intrinsics.Vector64.Create(a);

		/// <summary>
		/// Set packed 16-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e3"><c>short {UI16}</c></param>
		/// <param name="e2"><c>short {UI16}</c></param>
		/// <param name="e1"><c>short {UI16}</c></param>
		/// <param name="e0"><c>short {UI16}</c></param>
		/// <returns><c>__m64 dst {FP32}</c></returns>
		public static __m64 _mm_setr_pi16(short e3, short e2, short e1, short e0) => System.Runtime.Intrinsics.Vector64.Create((ushort)e3, (ushort)e2, (ushort)e1, (ushort)e0);

		/// <summary>
		/// Set packed 32-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e1"><c>int {UI32}</c></param>
		/// <param name="e0"><c>int {UI32}</c></param>
		/// <returns><c>__m64 dst {FP32}</c></returns>
		public static __m64 _mm_setr_pi32(int e1, int e0) => System.Runtime.Intrinsics.Vector64.Create((uint)e1, (uint)e0);

		/// <summary>
		/// Set packed 8-bit integers in "dst" with the supplied values in reverse order.
		/// </summary>
		/// <remarks><c></c></remarks>
		/// <param name="e7"><c>byte {UI8}</c></param>
		/// <param name="e6"><c>byte {UI8}</c></param>
		/// <param name="e5"><c>byte {UI8}</c></param>
		/// <param name="e4"><c>byte {UI8}</c></param>
		/// <param name="e3"><c>byte {UI8}</c></param>
		/// <param name="e2"><c>byte {UI8}</c></param>
		/// <param name="e1"><c>byte {UI8}</c></param>
		/// <param name="e0"><c>byte {UI8}</c></param>
		/// <returns><c>__m64 dst {FP32}</c></returns>
		public static __m64 _mm_setr_pi8(byte e7, byte e6, byte e5, byte e4, byte e3, byte e2, byte e1, byte e0) => System.Runtime.Intrinsics.Vector64.Create(e7, e6, e5, e4, e3, e2, e1, e0);

	}
}
