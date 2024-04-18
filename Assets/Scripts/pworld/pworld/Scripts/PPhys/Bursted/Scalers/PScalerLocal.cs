using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Handlers;

namespace pworld.Scripts.PPhys.Bursted.Scalers
{
	public class PScalerLocal : PBurstSpringWorkerScale
	{
		public Vector3 target;

		public override Vector3 Target
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PScalerLocal()
		{

		}
	}
}
