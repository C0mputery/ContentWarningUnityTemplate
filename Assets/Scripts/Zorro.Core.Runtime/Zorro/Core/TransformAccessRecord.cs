using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Jobs;

namespace Zorro.Core
{
	public class TransformAccessRecord : BookkeepingRecord
	{
		public TransformAccessArray TransformAccessArray;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TransformAccessRecord(int capacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(Transform value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RemoveAtSwapBack(int index)
		{
			throw null;
		}
	}
}
