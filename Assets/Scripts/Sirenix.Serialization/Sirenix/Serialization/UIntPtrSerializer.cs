using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class UIntPtrSerializer : Serializer<UIntPtr>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UIntPtr ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, UIntPtr value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIntPtrSerializer()
		{
			throw null;
		}
	}
}
