using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		protected int capacity;

		protected TInfo info;

		private TType[] freeObj;

		protected int pos;

		protected string name;

		private bool inited;

		internal string LogPrefix
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public TInfo Info
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected abstract TType createObject(TInfo info);

		protected abstract void destroyObject(TType obj);

		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectPool(int capacity, string name)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectPool(int capacity, string name, TInfo info)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(TInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TType AcquireOrCreate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TType AcquireOrCreate(TInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Release(TType obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
