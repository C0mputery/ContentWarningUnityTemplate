using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebSocketSharp.Net
{
	[Serializable]
	public class CookieCollection : ICollection<Cookie>, IEnumerable<Cookie>, IEnumerable
	{
		private List<Cookie> _list;

		private bool _readOnly;

		private object _sync;

		internal IList<Cookie> List
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal IEnumerable<Cookie> Sorted
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public bool IsSynchronized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Cookie this[int index]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Cookie this[string name]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public object SyncRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CookieCollection()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void add(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int compareForSort(Cookie x, Cookie y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int compareForSorted(Cookie x, Cookie y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static CookieCollection parseRequest(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static CookieCollection parseResponse(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int search(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string urlDecode(string s, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CookieCollection Parse(string value, bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetOrRemove(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetOrRemove(CookieCollection cookies)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Sort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(CookieCollection cookies)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyTo(Cookie[] array, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<Cookie> GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Remove(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
