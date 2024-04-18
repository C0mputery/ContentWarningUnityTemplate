using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class MultiDimensionalArrayFormatter<TArray, TElement> : BaseFormatter<TArray> where TArray : class
	{
		private const string RANKS_NAME = "ranks";

		private const char RANKS_SEPARATOR = '|';

		private static readonly int ArrayRank;

		private static readonly Serializer<TElement> ValueReaderWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MultiDimensionalArrayFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override TArray GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref TArray value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref TArray value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayWrite(Array a, Func<TElement> write)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayWrite(Array a, int rank, int[] indices, Func<TElement> write)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayRead(Array a, Action<TElement> read)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IterateArrayRead(Array a, int rank, int[] indices, Action<TElement> read)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiDimensionalArrayFormatter()
		{

		}
	}
}
