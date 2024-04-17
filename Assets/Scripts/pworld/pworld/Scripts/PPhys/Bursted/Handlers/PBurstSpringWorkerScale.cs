using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public abstract class PBurstSpringWorkerScale : PBurstSpringWorkerBase<Vector3, SpringJobScale.SpringData, SpringJobScale, PBurstSpringManagerScale>
	{
		public override PBurstSpringManagerScale Manager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SpringJobScale.SpringData GetDefaultData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PBurstSpringWorkerScale()
		{
			throw null;
		}
	}
}
