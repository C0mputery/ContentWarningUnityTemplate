using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class BaseDictionaryKeyPathProvider<T> : IDictionaryKeyPathProvider<T>, IDictionaryKeyPathProvider, IComparer<T>
	{
		public abstract string ProviderID { get; }

		public abstract T GetKeyFromPathString(string pathStr);

		public abstract string GetPathStringFromKey(T key);

		public abstract int Compare(T x, T y);

		[MethodImpl(MethodImplOptions.NoInlining)]
		int IDictionaryKeyPathProvider.Compare(object x, object y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		object IDictionaryKeyPathProvider.GetKeyFromPathString(string pathStr)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		string IDictionaryKeyPathProvider.GetPathStringFromKey(object key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BaseDictionaryKeyPathProvider()
		{
			throw null;
		}
	}
}
