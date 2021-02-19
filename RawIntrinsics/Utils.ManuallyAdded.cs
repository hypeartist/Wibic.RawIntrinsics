namespace RawIntrinsics
{
	public static class Utils
	{
		public static int _MM_SHUFFLE(int z, int y, int x, int w) => (z << 6) | (y << 4) | (x << 2) | w;
	}
}
