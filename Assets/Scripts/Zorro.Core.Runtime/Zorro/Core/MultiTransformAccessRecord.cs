using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Jobs;

namespace Zorro.Core
{
	public class MultiTransformAccessRecord : BookkeepingRecord
	{
		public int DataPerEntry;

		public TransformAccessArray TransformAccessArray;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiTransformAccessRecord(int dataPerEntry, int capacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(Transform transform)
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
