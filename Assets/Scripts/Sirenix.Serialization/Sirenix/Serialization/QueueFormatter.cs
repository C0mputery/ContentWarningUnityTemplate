using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class QueueFormatter<TQueue, TValue> : BaseFormatter<TQueue> where TQueue : Queue<TValue>, new()
	{
		private static readonly Serializer<TValue> TSerializer;

		private static readonly bool IsPlainQueue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static QueueFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public QueueFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override TQueue GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref TQueue value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref TQueue value, IDataWriter writer)
		{
			throw null;
		}
	}
}
