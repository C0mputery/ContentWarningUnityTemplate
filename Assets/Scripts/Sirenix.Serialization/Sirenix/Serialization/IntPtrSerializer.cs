using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class IntPtrSerializer : Serializer<IntPtr>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IntPtr ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, IntPtr value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IntPtrSerializer()
		{
			throw null;
		}
	}
}
