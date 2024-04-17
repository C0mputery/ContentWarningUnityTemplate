using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class SelfFormatterFormatter<T> : BaseFormatter<T> where T : ISelfFormatter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref T value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelfFormatterFormatter()
		{
			throw null;
		}
	}
}
