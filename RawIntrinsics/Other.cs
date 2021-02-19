namespace RawIntrinsics
{
	public static unsafe partial class Other
	{
		/// <summary>
		/// Perform one round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and store the result in "dst".
		/// </summary>
		/// <remarks><c>AESDEC xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="RoundKey"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_aesdec_si128(__m128i a, __m128i RoundKey) => System.Runtime.Intrinsics.X86.Aes.Decrypt(a.UI8, RoundKey.UI8);

		/// <summary>
		/// Perform the last round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and store the result in "dst".
		/// </summary>
		/// <remarks><c>AESDECLAST xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="RoundKey"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_aesdeclast_si128(__m128i a, __m128i RoundKey) => System.Runtime.Intrinsics.X86.Aes.DecryptLast(a.UI8, RoundKey.UI8);

		/// <summary>
		/// Perform one round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and store the result in "dst"."
		/// </summary>
		/// <remarks><c>AESENC xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="RoundKey"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_aesenc_si128(__m128i a, __m128i RoundKey) => System.Runtime.Intrinsics.X86.Aes.Encrypt(a.UI8, RoundKey.UI8);

		/// <summary>
		/// Perform the last round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and store the result in "dst"."
		/// </summary>
		/// <remarks><c>AESENCLAST xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="RoundKey"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_aesenclast_si128(__m128i a, __m128i RoundKey) => System.Runtime.Intrinsics.X86.Aes.EncryptLast(a.UI8, RoundKey.UI8);

		/// <summary>
		/// Perform the InvMixColumns transformation on "a" and store the result in "dst".
		/// </summary>
		/// <remarks><c>AESIMC xmm, xmm</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_aesimc_si128(__m128i a) => System.Runtime.Intrinsics.X86.Aes.InverseMixColumns(a.UI8);

		/// <summary>
		/// Assist in expanding the AES cipher key by computing steps towards generating a round key for encryption cipher using data from "a" and an 8-bit round constant specified in "imm8", and store the result in "dst"."
		/// </summary>
		/// <remarks><c>AESKEYGENASSIST xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_aeskeygenassist_si128(__m128i a, int imm8) => System.Runtime.Intrinsics.X86.Aes.KeygenAssist(a.UI8, (byte)imm8);

		/// <summary>
		/// Perform a carry-less multiplication of two 64-bit integers, selected from "a" and "b" according to "imm8", and store the results in "dst".
		/// </summary>
		/// <remarks><c>PCLMULQDQ xmm, xmm, imm8</c></remarks>
		/// <param name="a"><c>__m128i {M128}</c></param>
		/// <param name="b"><c>__m128i {M128}</c></param>
		/// <param name="imm8"><c>int {IMM}</c></param>
		/// <returns><c>__m128i dst {M128}</c></returns>
		public static __m128i _mm_clmulepi64_si128(__m128i a, __m128i b, int imm8) => System.Runtime.Intrinsics.X86.Pclmulqdq.CarrylessMultiply(a.SI64, b.SI64, (byte)imm8);

		/// <summary>
		/// Count the number of bits set to 1 in unsigned 32-bit integer "a", and return that count in "dst".
		/// </summary>
		/// <remarks><c>POPCNT r32, r32</c></remarks>
		/// <param name="a"><c>int {UI32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_popcnt_u32(int a) => (int)System.Runtime.Intrinsics.X86.Popcnt.PopCount((uint)a);

		/// <summary>
		/// Count the number of bits set to 1 in unsigned 64-bit integer "a", and return that count in "dst".
		/// </summary>
		/// <remarks><c>POPCNT r64, r64</c></remarks>
		/// <param name="a"><c>long {UI64}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_popcnt_u64(long a) => (long)System.Runtime.Intrinsics.X86.Popcnt.X64.PopCount((ulong)a);

		/// <summary>
		/// Count the number of trailing zero bits in unsigned 32-bit integer "a", and return that count in "dst".
		/// </summary>
		/// <remarks><c>TZCNT r32, r32</c></remarks>
		/// <param name="a"><c>int {UI32}</c></param>
		/// <returns><c>int dst {UI32}</c></returns>
		public static int _mm_tzcnt_32(int a) => (int)System.Runtime.Intrinsics.X86.Bmi1.TrailingZeroCount((uint)a);

		/// <summary>
		/// Count the number of trailing zero bits in unsigned 64-bit integer "a", and return that count in "dst".
		/// </summary>
		/// <remarks><c>TZCNT r64, r64</c></remarks>
		/// <param name="a"><c>long {UI64}</c></param>
		/// <returns><c>long dst {UI64}</c></returns>
		public static long _mm_tzcnt_64(long a) => (long)System.Runtime.Intrinsics.X86.Bmi1.X64.TrailingZeroCount((ulong)a);

	}
}
