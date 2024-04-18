using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public class PBurstSpringManagerRotation : PBurstSpringManagerBase<SpringJobRotation, SpringJobRotation.SpringData, Quaternion>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SpringJobRotation GetNewJob()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PBurstSpringManagerRotation()
		{

		}
	}
}
