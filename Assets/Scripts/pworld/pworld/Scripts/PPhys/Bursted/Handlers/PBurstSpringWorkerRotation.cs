using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public abstract class PBurstSpringWorkerRotation : PBurstSpringWorkerBase<Quaternion, SpringJobRotation.SpringData, SpringJobRotation, PBurstSpringManagerRotation>
	{
		public override PBurstSpringManagerRotation Manager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SpringJobRotation.SpringData GetDefaultData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PBurstSpringWorkerRotation()
		{
			throw null;
		}
	}
}
