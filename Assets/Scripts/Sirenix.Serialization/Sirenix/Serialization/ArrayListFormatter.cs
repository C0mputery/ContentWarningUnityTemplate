using System.Collections;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class ArrayListFormatter : BaseFormatter<ArrayList>
	{
		private static readonly Serializer<object> ObjectSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ArrayList GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref ArrayList value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref ArrayList value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayListFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArrayListFormatter()
		{
			throw null;
		}
	}
}
