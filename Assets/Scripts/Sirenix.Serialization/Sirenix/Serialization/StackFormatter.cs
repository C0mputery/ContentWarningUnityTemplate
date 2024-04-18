using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class StackFormatter<TStack, TValue> : BaseFormatter<TStack> where TStack : Stack<TValue>, new()
	{
		private static readonly Serializer<TValue> TSerializer;

		private static readonly bool IsPlainStack;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StackFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override TStack GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref TStack value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref TStack value, IDataWriter writer)
		{
			throw null;
		}
	}
}
