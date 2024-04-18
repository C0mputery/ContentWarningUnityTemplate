using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public class ObjectNativeBookkeeper<T> : NativeBookkeeper<T> where T : Object
	{
		private Dictionary<int, T> m_instanceIDLookup;

		public BidirectionalNativeDictionary<int, int> InstanceIDtoIndexHash;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectNativeBookkeeper(int defaultCapacity) : base(69)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T GetFromInstanceID(int instanceID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int Add(T newEntry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BookkeperRemovalInfo Remove(T entry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}
	}
}
