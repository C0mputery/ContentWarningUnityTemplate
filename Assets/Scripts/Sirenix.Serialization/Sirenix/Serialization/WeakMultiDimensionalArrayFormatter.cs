using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class WeakMultiDimensionalArrayFormatter : WeakBaseFormatter
	{
		private const string RANKS_NAME = "ranks";

		private const char RANKS_SEPARATOR = '|';

		private readonly int ArrayRank;

		private readonly Type ElementType;

		private readonly Serializer ValueReaderWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakMultiDimensionalArrayFormatter(Type arrayType, Type elementType) : base(null)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayWrite(Array a, Func<object> write)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayWrite(Array a, int rank, int[] indices, Func<object> write)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayRead(Array a, Action<object> read)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayRead(Array a, int rank, int[] indices, Action<object> read)
		{
			throw null;
		}
	}
}
