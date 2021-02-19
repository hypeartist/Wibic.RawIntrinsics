namespace RawIntrinsics
{
	public static partial class MMX
	{
		/// <summary>
		/// Return vector of type __m64 with all elements set to zero.
		/// </summary>
		/// <returns><c>__m64 dst {FP32}</c></returns>
		public static __m64 _mm_setzero_si64() => System.Runtime.Intrinsics.Vector64<float>.Zero;
	}
}