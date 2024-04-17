using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public static class GarbageFreeIterators
	{
		public struct ListIterator<T> : IDisposable
		{
			private bool isNull;

			private List<T> list;

			private List<T>.Enumerator enumerator;

			public T Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ListIterator(List<T> list)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ListIterator<T> GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool MoveNext()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public struct HashsetIterator<T> : IDisposable
		{
			private bool isNull;

			private HashSet<T> hashset;

			private HashSet<T>.Enumerator enumerator;

			public T Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HashsetIterator(HashSet<T> hashset)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HashsetIterator<T> GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool MoveNext()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public struct DictionaryIterator<T1, T2> : IDisposable
		{
			private Dictionary<T1, T2> dictionary;

			private Dictionary<T1, T2>.Enumerator enumerator;

			private bool isNull;

			public KeyValuePair<T1, T2> Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public DictionaryIterator(Dictionary<T1, T2> dictionary)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public DictionaryIterator<T1, T2> GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool MoveNext()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public struct DictionaryValueIterator<T1, T2> : IDisposable
		{
			private Dictionary<T1, T2> dictionary;

			private Dictionary<T1, T2>.Enumerator enumerator;

			private bool isNull;

			public T2 Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public DictionaryValueIterator(Dictionary<T1, T2> dictionary)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public DictionaryValueIterator<T1, T2> GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool MoveNext()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ListIterator<T> GFIterator<T>(this List<T> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DictionaryIterator<T1, T2> GFIterator<T1, T2>(this Dictionary<T1, T2> dictionary)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DictionaryValueIterator<T1, T2> GFValueIterator<T1, T2>(this Dictionary<T1, T2> dictionary)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HashsetIterator<T> GFIterator<T>(this HashSet<T> hashset)
		{
			throw null;
		}
	}
}
