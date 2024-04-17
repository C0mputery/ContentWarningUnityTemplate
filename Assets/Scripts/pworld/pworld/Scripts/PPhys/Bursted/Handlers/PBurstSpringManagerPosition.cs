using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public class PBurstSpringManagerPosition : PBurstSpringManagerBase<SpringJobPosition, SpringJobPosition.SpringData, Vector3>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SpringJobPosition GetNewJob()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PBurstSpringManagerPosition()
		{
			throw null;
		}
	}
}
