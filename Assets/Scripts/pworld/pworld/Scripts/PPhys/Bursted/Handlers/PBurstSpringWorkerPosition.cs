using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public abstract class PBurstSpringWorkerPosition : PBurstSpringWorkerBase<Vector3, SpringJobPosition.SpringData, SpringJobPosition, PBurstSpringManagerPosition>
	{
		public override PBurstSpringManagerPosition Manager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SpringJobPosition.SpringData GetDefaultData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PBurstSpringWorkerPosition()
		{
			throw null;
		}
	}
}
