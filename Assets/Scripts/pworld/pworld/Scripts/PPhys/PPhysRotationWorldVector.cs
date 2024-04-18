using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys
{
	public class PPhysRotationWorldVector : PPhysRotationBase
	{
		public override Vector3 TargetUp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override Quaternion CurrentRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Rotate(Vector3 dRot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PPhysRotationWorldVector()
		{

		}
	}
}
