namespace RawIntrinsics
{
	public struct __m64
	{
		private System.Runtime.Intrinsics.Vector64<byte> _;
		public System.Runtime.Intrinsics.Vector64<byte> UI8 => System.Runtime.Intrinsics.Vector64.AsByte(_);
		public System.Runtime.Intrinsics.Vector64<sbyte> SI8 => System.Runtime.Intrinsics.Vector64.AsSByte(_);
		public System.Runtime.Intrinsics.Vector64<ushort> UI16 => System.Runtime.Intrinsics.Vector64.AsUInt16(_);
		public System.Runtime.Intrinsics.Vector64<short> SI16 => System.Runtime.Intrinsics.Vector64.AsInt16(_);
		public System.Runtime.Intrinsics.Vector64<uint> UI32 => System.Runtime.Intrinsics.Vector64.AsUInt32(_);
		public System.Runtime.Intrinsics.Vector64<int> SI32 => System.Runtime.Intrinsics.Vector64.AsInt32(_);
		public System.Runtime.Intrinsics.Vector64<ulong> UI64 => System.Runtime.Intrinsics.Vector64.AsUInt64(_);
		public System.Runtime.Intrinsics.Vector64<long> SI64 => System.Runtime.Intrinsics.Vector64.AsInt64(_);
		public System.Runtime.Intrinsics.Vector64<float> FP32 => System.Runtime.Intrinsics.Vector64.AsSingle(_);
		public System.Runtime.Intrinsics.Vector64<double> FP64 => System.Runtime.Intrinsics.Vector64.AsDouble(_);
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<byte> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<sbyte> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<ushort> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<short> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<uint> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<int> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<ulong> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<long> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<float> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
		public static implicit operator __m64(System.Runtime.Intrinsics.Vector64<double> v) => new __m64 { _ = System.Runtime.Intrinsics.Vector64.AsByte(v) };
	}

	public struct __m128
	{
		private System.Runtime.Intrinsics.Vector128<byte> _;
		public System.Runtime.Intrinsics.Vector128<byte> UI8 => System.Runtime.Intrinsics.Vector128.AsByte(_);
		public System.Runtime.Intrinsics.Vector128<sbyte> SI8 => System.Runtime.Intrinsics.Vector128.AsSByte(_);
		public System.Runtime.Intrinsics.Vector128<ushort> UI16 => System.Runtime.Intrinsics.Vector128.AsUInt16(_);
		public System.Runtime.Intrinsics.Vector128<short> SI16 => System.Runtime.Intrinsics.Vector128.AsInt16(_);
		public System.Runtime.Intrinsics.Vector128<uint> UI32 => System.Runtime.Intrinsics.Vector128.AsUInt32(_);
		public System.Runtime.Intrinsics.Vector128<int> SI32 => System.Runtime.Intrinsics.Vector128.AsInt32(_);
		public System.Runtime.Intrinsics.Vector128<ulong> UI64 => System.Runtime.Intrinsics.Vector128.AsUInt64(_);
		public System.Runtime.Intrinsics.Vector128<long> SI64 => System.Runtime.Intrinsics.Vector128.AsInt64(_);
		public System.Runtime.Intrinsics.Vector128<float> FP32 => System.Runtime.Intrinsics.Vector128.AsSingle(_);
		public System.Runtime.Intrinsics.Vector128<double> FP64 => System.Runtime.Intrinsics.Vector128.AsDouble(_);
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<byte> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<sbyte> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<ushort> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<short> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<uint> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<int> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<ulong> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<long> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<float> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128(System.Runtime.Intrinsics.Vector128<double> v) => new __m128 { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
	}

	public struct __m128i
	{
		private System.Runtime.Intrinsics.Vector128<byte> _;
		public System.Runtime.Intrinsics.Vector128<byte> UI8 => System.Runtime.Intrinsics.Vector128.AsByte(_);
		public System.Runtime.Intrinsics.Vector128<sbyte> SI8 => System.Runtime.Intrinsics.Vector128.AsSByte(_);
		public System.Runtime.Intrinsics.Vector128<ushort> UI16 => System.Runtime.Intrinsics.Vector128.AsUInt16(_);
		public System.Runtime.Intrinsics.Vector128<short> SI16 => System.Runtime.Intrinsics.Vector128.AsInt16(_);
		public System.Runtime.Intrinsics.Vector128<uint> UI32 => System.Runtime.Intrinsics.Vector128.AsUInt32(_);
		public System.Runtime.Intrinsics.Vector128<int> SI32 => System.Runtime.Intrinsics.Vector128.AsInt32(_);
		public System.Runtime.Intrinsics.Vector128<ulong> UI64 => System.Runtime.Intrinsics.Vector128.AsUInt64(_);
		public System.Runtime.Intrinsics.Vector128<long> SI64 => System.Runtime.Intrinsics.Vector128.AsInt64(_);
		public System.Runtime.Intrinsics.Vector128<float> FP32 => System.Runtime.Intrinsics.Vector128.AsSingle(_);
		public System.Runtime.Intrinsics.Vector128<double> FP64 => System.Runtime.Intrinsics.Vector128.AsDouble(_);
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<byte> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<sbyte> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<ushort> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<short> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<uint> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<int> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<ulong> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<long> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<float> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128i(System.Runtime.Intrinsics.Vector128<double> v) => new __m128i { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
	}

	public struct __m128d
	{
		private System.Runtime.Intrinsics.Vector128<byte> _;
		public System.Runtime.Intrinsics.Vector128<byte> UI8 => System.Runtime.Intrinsics.Vector128.AsByte(_);
		public System.Runtime.Intrinsics.Vector128<sbyte> SI8 => System.Runtime.Intrinsics.Vector128.AsSByte(_);
		public System.Runtime.Intrinsics.Vector128<ushort> UI16 => System.Runtime.Intrinsics.Vector128.AsUInt16(_);
		public System.Runtime.Intrinsics.Vector128<short> SI16 => System.Runtime.Intrinsics.Vector128.AsInt16(_);
		public System.Runtime.Intrinsics.Vector128<uint> UI32 => System.Runtime.Intrinsics.Vector128.AsUInt32(_);
		public System.Runtime.Intrinsics.Vector128<int> SI32 => System.Runtime.Intrinsics.Vector128.AsInt32(_);
		public System.Runtime.Intrinsics.Vector128<ulong> UI64 => System.Runtime.Intrinsics.Vector128.AsUInt64(_);
		public System.Runtime.Intrinsics.Vector128<long> SI64 => System.Runtime.Intrinsics.Vector128.AsInt64(_);
		public System.Runtime.Intrinsics.Vector128<float> FP32 => System.Runtime.Intrinsics.Vector128.AsSingle(_);
		public System.Runtime.Intrinsics.Vector128<double> FP64 => System.Runtime.Intrinsics.Vector128.AsDouble(_);
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<byte> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<sbyte> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<ushort> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<short> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<uint> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<int> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<ulong> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<long> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<float> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
		public static implicit operator __m128d(System.Runtime.Intrinsics.Vector128<double> v) => new __m128d { _ = System.Runtime.Intrinsics.Vector128.AsByte(v) };
	}

	public struct __m256
	{
		private System.Runtime.Intrinsics.Vector256<byte> _;
		public System.Runtime.Intrinsics.Vector256<byte> UI8 => System.Runtime.Intrinsics.Vector256.AsByte(_);
		public System.Runtime.Intrinsics.Vector256<sbyte> SI8 => System.Runtime.Intrinsics.Vector256.AsSByte(_);
		public System.Runtime.Intrinsics.Vector256<ushort> UI16 => System.Runtime.Intrinsics.Vector256.AsUInt16(_);
		public System.Runtime.Intrinsics.Vector256<short> SI16 => System.Runtime.Intrinsics.Vector256.AsInt16(_);
		public System.Runtime.Intrinsics.Vector256<uint> UI32 => System.Runtime.Intrinsics.Vector256.AsUInt32(_);
		public System.Runtime.Intrinsics.Vector256<int> SI32 => System.Runtime.Intrinsics.Vector256.AsInt32(_);
		public System.Runtime.Intrinsics.Vector256<ulong> UI64 => System.Runtime.Intrinsics.Vector256.AsUInt64(_);
		public System.Runtime.Intrinsics.Vector256<long> SI64 => System.Runtime.Intrinsics.Vector256.AsInt64(_);
		public System.Runtime.Intrinsics.Vector256<float> FP32 => System.Runtime.Intrinsics.Vector256.AsSingle(_);
		public System.Runtime.Intrinsics.Vector256<double> FP64 => System.Runtime.Intrinsics.Vector256.AsDouble(_);
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<byte> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<sbyte> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<ushort> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<short> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<uint> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<int> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<ulong> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<long> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<float> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256(System.Runtime.Intrinsics.Vector256<double> v) => new __m256 { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
	}

	public struct __m256i
	{
		private System.Runtime.Intrinsics.Vector256<byte> _;
		public System.Runtime.Intrinsics.Vector256<byte> UI8 => System.Runtime.Intrinsics.Vector256.AsByte(_);
		public System.Runtime.Intrinsics.Vector256<sbyte> SI8 => System.Runtime.Intrinsics.Vector256.AsSByte(_);
		public System.Runtime.Intrinsics.Vector256<ushort> UI16 => System.Runtime.Intrinsics.Vector256.AsUInt16(_);
		public System.Runtime.Intrinsics.Vector256<short> SI16 => System.Runtime.Intrinsics.Vector256.AsInt16(_);
		public System.Runtime.Intrinsics.Vector256<uint> UI32 => System.Runtime.Intrinsics.Vector256.AsUInt32(_);
		public System.Runtime.Intrinsics.Vector256<int> SI32 => System.Runtime.Intrinsics.Vector256.AsInt32(_);
		public System.Runtime.Intrinsics.Vector256<ulong> UI64 => System.Runtime.Intrinsics.Vector256.AsUInt64(_);
		public System.Runtime.Intrinsics.Vector256<long> SI64 => System.Runtime.Intrinsics.Vector256.AsInt64(_);
		public System.Runtime.Intrinsics.Vector256<float> FP32 => System.Runtime.Intrinsics.Vector256.AsSingle(_);
		public System.Runtime.Intrinsics.Vector256<double> FP64 => System.Runtime.Intrinsics.Vector256.AsDouble(_);
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<byte> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<sbyte> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<ushort> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<short> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<uint> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<int> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<ulong> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<long> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<float> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256i(System.Runtime.Intrinsics.Vector256<double> v) => new __m256i { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
	}

	public struct __m256d
	{
		private System.Runtime.Intrinsics.Vector256<byte> _;
		public System.Runtime.Intrinsics.Vector256<byte> UI8 => System.Runtime.Intrinsics.Vector256.AsByte(_);
		public System.Runtime.Intrinsics.Vector256<sbyte> SI8 => System.Runtime.Intrinsics.Vector256.AsSByte(_);
		public System.Runtime.Intrinsics.Vector256<ushort> UI16 => System.Runtime.Intrinsics.Vector256.AsUInt16(_);
		public System.Runtime.Intrinsics.Vector256<short> SI16 => System.Runtime.Intrinsics.Vector256.AsInt16(_);
		public System.Runtime.Intrinsics.Vector256<uint> UI32 => System.Runtime.Intrinsics.Vector256.AsUInt32(_);
		public System.Runtime.Intrinsics.Vector256<int> SI32 => System.Runtime.Intrinsics.Vector256.AsInt32(_);
		public System.Runtime.Intrinsics.Vector256<ulong> UI64 => System.Runtime.Intrinsics.Vector256.AsUInt64(_);
		public System.Runtime.Intrinsics.Vector256<long> SI64 => System.Runtime.Intrinsics.Vector256.AsInt64(_);
		public System.Runtime.Intrinsics.Vector256<float> FP32 => System.Runtime.Intrinsics.Vector256.AsSingle(_);
		public System.Runtime.Intrinsics.Vector256<double> FP64 => System.Runtime.Intrinsics.Vector256.AsDouble(_);
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<byte> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<sbyte> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<ushort> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<short> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<uint> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<int> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<ulong> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<long> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<float> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
		public static implicit operator __m256d(System.Runtime.Intrinsics.Vector256<double> v) => new __m256d { _ = System.Runtime.Intrinsics.Vector256.AsByte(v) };
	}

}
