using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class NonAllocDictionary<K, V> : IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable where K : IEquatable<K>
	{
		public struct KeyIterator : IEnumerator<K>, IEnumerator, IDisposable
		{
			private int _index;

			private NonAllocDictionary<K, V> _dict;

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public K Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public KeyIterator(NonAllocDictionary<K, V> dictionary)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public KeyIterator GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
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

		public struct ValueIterator : IEnumerator<V>, IEnumerator, IDisposable
		{
			private int _index;

			private NonAllocDictionary<K, V> _dict;

			public V Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ValueIterator(NonAllocDictionary<K, V> dictionary)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ValueIterator GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
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

		public struct PairIterator : IEnumerator<KeyValuePair<K, V>>, IEnumerator, IDisposable
		{
			private int _index;

			private NonAllocDictionary<K, V> _dict;

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public KeyValuePair<K, V> Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PairIterator(NonAllocDictionary<K, V> dictionary)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
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

		private struct Node
		{
			public bool Used;

			public int Next;

			public uint Hash;

			public K Key;

			public V Val;
		}

		private static uint[] _primeTableUInt;

		private int _freeHead;

		private int _freeCount;

		private int _usedCount;

		private uint _capacity;

		private int[] _buckets;

		private Node[] _nodes;

		private bool isReadOnly;

		private ICollection<K> keys;

		private ICollection<V> values;

		public KeyIterator Keys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		ICollection<V> IDictionary<K, V>.Values
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		ICollection<K> IDictionary<K, V>.Keys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public ValueIterator Values
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public uint Capacity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public V this[K key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NonAllocDictionary(uint capacity = 29u)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsKey(K key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(KeyValuePair<K, V> item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(K key, out V val)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(K key, V val)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(K key, V val)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(KeyValuePair<K, V> item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Remove(K key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Remove(KeyValuePair<K, V> item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PairIterator GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int FindNode(K key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Insert(K key, V val)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Expand()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<KeyValuePair<K, V>>.CopyTo(KeyValuePair<K, V>[] array, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool IsPrimeFromList(uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static uint GetNextPrime(uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Assert(bool condition)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NonAllocDictionary()
		{
			throw null;
		}
	}
}
