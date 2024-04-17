using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class EmptyTypeFormatter<T> : EasyBaseFormatter<T>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void WriteDataEntries(ref T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmptyTypeFormatter()
		{
			throw null;
		}
	}
}
