using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakListFormatter : WeakBaseFormatter
	{
		private readonly Serializer ElementSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakListFormatter(Type serializedType) : base(serializedType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override object GetUninitializedObject()
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
