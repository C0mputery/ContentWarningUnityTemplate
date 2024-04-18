using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys.Bursted.Rotators
{
	public class PRotatorWithRightOfTarget : PRotatorLookAt
	{
		public override Vector3 TargetUp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PRotatorWithRightOfTarget()
		{

		}
	}
}
