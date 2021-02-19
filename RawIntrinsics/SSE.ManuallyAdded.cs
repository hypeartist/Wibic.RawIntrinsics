namespace RawIntrinsics
{
	public static partial class SSE
	{
		/// <summary>
		/// Return vector of type __m128 with all elements set to zero.
		/// </summary>
		/// <returns><c>__m128 dst {FP32}</c></returns>
		public static __m128 _mm_setzero_ps() => System.Runtime.Intrinsics.Vector128<float>.Zero;
	}
}