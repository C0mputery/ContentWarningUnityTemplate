using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Zorro.Core
{
	public static class NativeArrayExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] ToByteArray(this NativeArray<byte> nativeArray)
		{
			throw null;
		}
	}
}
