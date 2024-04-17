using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public static class GenericCollectionFormatter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CanFormat(Type type, out Type elementType)
		{
			throw null;
		}
	}
	public sealed class GenericCollectionFormatter<TCollection, TElement> : BaseFormatter<TCollection> where TCollection : ICollection<TElement>, new()
	{
		private static Serializer<TElement> valueReaderWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GenericCollectionFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GenericCollectionFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override TCollection GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref TCollection value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref TCollection value, IDataWriter writer)
		{
			throw null;
		}
	}
}
