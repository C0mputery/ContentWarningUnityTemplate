using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class PrimitiveArrayFormatter<T> : MinimalBaseFormatter<T[]> where T : struct
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override T[] GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref T[] value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref T[] value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrimitiveArrayFormatter()
		{
			throw null;
		}
	}
}
