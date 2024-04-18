using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public class PBurstSpringManagerScale : PBurstSpringManagerBase<SpringJobScale, SpringJobScale.SpringData, Vector3>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SpringJobScale GetNewJob()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PBurstSpringManagerScale()
		{

		}
	}
}
