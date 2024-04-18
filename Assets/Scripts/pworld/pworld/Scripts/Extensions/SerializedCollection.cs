using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace pworld.Scripts.Extensions
{
	[Serializable]
	public class SerializedCollection<T> : IEnumerable
	{
		public T[] collection;

		public T this[int key]
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
		public SerializedCollection(T[] coll)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator T[](SerializedCollection<T> SC)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator SerializedCollection<T>(T[] col)
		{
			throw null;
		}
	}
}
