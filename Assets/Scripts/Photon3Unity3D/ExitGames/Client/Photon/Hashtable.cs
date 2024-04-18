using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class Hashtable : Dictionary<object, object>
	{
		internal static readonly object[] boxedByte;

		public new object this[object key]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object GetBoxedByte(byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Hashtable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Hashtable()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Hashtable(int x)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(byte k, object v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Remove(byte k)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsKey(byte key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new DictionaryEntryEnumerator GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Clone()
		{
			throw null;
		}
	}
}
