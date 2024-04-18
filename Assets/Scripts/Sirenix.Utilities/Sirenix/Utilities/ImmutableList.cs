using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Utilities
{
	[Serializable]
	public sealed class ImmutableList : IImmutableList<object>, IImmutableList, IList, ICollection, IEnumerable, IList<object>, ICollection<object>, IEnumerable<object>
	{
		[CompilerGenerated]
		private sealed class _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DObject_003E_002DGetEnumerator_003Ed__25 : IEnumerator<object>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ImmutableList _003C_003E4__this;

			private IEnumerator _003C_003E7__wrap1;

			object IEnumerator<object>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DObject_003E_002DGetEnumerator_003Ed__25(int _003C_003E1__state)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				throw null;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void _003C_003Em__Finally1()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		[SerializeField]
		private IList innerList;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsFixedSize
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

		public bool IsSynchronized
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

		object IList.this[int index]
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

		object IList<object>.this[int index]
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

		public object this[int index]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImmutableList(IList innerList)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyTo(object[] array, int arrayIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyTo(Array array, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DObject_003E_002DGetEnumerator_003Ed__25))]
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.Add(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Insert(int index, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Remove(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.RemoveAt(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int IndexOf(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<object>.RemoveAt(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<object>.Insert(int index, object item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<object>.Add(object item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<object>.Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ICollection<object>.Remove(object item)
		{
			throw null;
		}
	}
	[Serializable]
	public sealed class ImmutableList<T> : IImmutableList<T>, IImmutableList, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T>
	{
		[SerializeField]
		private IList<T> innerList;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		bool ICollection.IsSynchronized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		object ICollection.SyncRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		bool IList.IsFixedSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		bool IList.IsReadOnly
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

		object IList.this[int index]
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

		T IList<T>.this[int index]
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

		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImmutableList(IList<T> innerList)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<T>.Add(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<T>.Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ICollection<T>.Remove(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.Add(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IList.Contains(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.IndexOf(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Insert(int index, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Remove(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<T>.Insert(int index, T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.RemoveAt(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int IndexOf(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<T>.RemoveAt(int index)
		{
			throw null;
		}
	}
	[Serializable]
	public sealed class ImmutableList<TList, TElement> : IImmutableList<TElement>, IImmutableList, IList, ICollection, IEnumerable, IList<TElement>, ICollection<TElement>, IEnumerable<TElement> where TList : IList<TElement>
	{
		private TList innerList;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		bool ICollection.IsSynchronized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		object ICollection.SyncRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		bool IList.IsFixedSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		bool IList.IsReadOnly
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

		object IList.this[int index]
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

		TElement IList<TElement>.this[int index]
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

		public TElement this[int index]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImmutableList(TList innerList)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(TElement item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyTo(TElement[] array, int arrayIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<TElement> GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<TElement>.Add(TElement item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<TElement>.Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ICollection<TElement>.Remove(TElement item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.Add(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IList.Contains(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.IndexOf(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Insert(int index, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Remove(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<TElement>.Insert(int index, TElement item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.RemoveAt(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int IndexOf(TElement item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<TElement>.RemoveAt(int index)
		{
			throw null;
		}
	}
}
