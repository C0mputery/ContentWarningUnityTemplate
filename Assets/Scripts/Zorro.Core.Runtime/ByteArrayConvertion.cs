using System.Runtime.CompilerServices;
using Unity.Collections;

public static class ByteArrayConvertion
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MoveToByteArray<T>(ref NativeArray<T> src, ref byte[] dst) where T : struct
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MoveFromByteArray<T>(ref byte[] src, ref NativeArray<T> dst) where T : struct
	{
		throw null;
	}
}
