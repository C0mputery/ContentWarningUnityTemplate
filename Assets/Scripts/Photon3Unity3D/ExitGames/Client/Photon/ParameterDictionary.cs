using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon.StructWrapping;

namespace ExitGames.Client.Photon
{
	public class ParameterDictionary : IEnumerable<KeyValuePair<byte, object>>, IEnumerable
	{
		public readonly NonAllocDictionary<byte, object> paramDict;

		public readonly StructWrapperPools wrapperPools;

		public object this[byte key]
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

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParameterDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParameterDictionary(int capacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator NonAllocDictionary<byte, object>(ParameterDictionary value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<KeyValuePair<byte, object>> IEnumerable<KeyValuePair<byte, object>>.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NonAllocDictionary<byte, object>.PairIterator GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, Hashtable value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte code, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Unwrap<T>(byte key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Get<T>(byte key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsKey(byte key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object TryGetObject(byte key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(byte key, out object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue<T>(byte key, out T value) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToStringFull(bool includeTypes = true)
		{
			throw null;
		}
	}
}
