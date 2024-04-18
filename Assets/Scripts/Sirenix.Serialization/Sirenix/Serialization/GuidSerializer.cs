using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class GuidSerializer : Serializer<Guid>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Guid ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, Guid value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuidSerializer()
		{

		}
	}
}
