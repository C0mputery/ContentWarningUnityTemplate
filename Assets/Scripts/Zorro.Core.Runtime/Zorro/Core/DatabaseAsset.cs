using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public abstract class DatabaseAsset<T, ObjectT> : SingletonAsset<T> where T : DatabaseAsset<T, ObjectT> where ObjectT : class
	{
		public ObjectT[] Objects;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ObjectT GetRandomEntry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EntryType GetRandomEntry<EntryType>() where EntryType : ObjectT
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected DatabaseAsset()
		{
			throw null;
		}
	}
}
