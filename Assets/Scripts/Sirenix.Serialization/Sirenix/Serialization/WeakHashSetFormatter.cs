using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakHashSetFormatter : WeakBaseFormatter
	{
		private readonly Serializer ElementSerializer;

		private readonly MethodInfo AddMethod;

		private readonly PropertyInfo CountProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakHashSetFormatter(Type serializedType) : base(null)
		{
			throw null;
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
