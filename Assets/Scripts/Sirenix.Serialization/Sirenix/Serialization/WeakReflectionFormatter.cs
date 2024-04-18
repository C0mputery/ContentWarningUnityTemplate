using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakReflectionFormatter : WeakBaseFormatter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakReflectionFormatter(Type serializedType) : base(serializedType)
		{

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
