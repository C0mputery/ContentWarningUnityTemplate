using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class WeakSelfFormatterFormatter : WeakBaseFormatter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakSelfFormatterFormatter(Type serializedType) : base(serializedType)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref object value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref object value, IDataWriter writer)
		{
			throw null;
		}
	}
}
