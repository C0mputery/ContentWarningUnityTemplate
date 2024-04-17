using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class EasyBaseFormatter<T> : BaseFormatter<T>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected sealed override void DeserializeImplementation(ref T value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected sealed override void SerializeImplementation(ref T value, IDataWriter writer)
		{
			throw null;
		}

		protected abstract void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader);

		protected abstract void WriteDataEntries(ref T value, IDataWriter writer);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected EasyBaseFormatter()
		{
			throw null;
		}
	}
}
