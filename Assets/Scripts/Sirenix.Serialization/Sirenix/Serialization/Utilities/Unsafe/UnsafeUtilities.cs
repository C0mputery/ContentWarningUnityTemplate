using System.Runtime.CompilerServices;

namespace Sirenix.Serialization.Utilities.Unsafe
{
	internal static class UnsafeUtilities
	{
		private struct Struct256Bit
		{
			public decimal d1;

			public decimal d2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] StructArrayToBytes<T>(T[] array) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int StringToBytes(byte[] buffer, string value, bool needs16BitSupport)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe static void MemoryCopy(void* from, void* to, int bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset)
		{
			throw null;
		}
	}
}
