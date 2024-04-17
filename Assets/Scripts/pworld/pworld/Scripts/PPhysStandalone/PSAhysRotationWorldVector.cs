using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys;

namespace pworld.Scripts.PPhysStandalone
{
	public class PSAhysRotationWorldVector : PPhysRotationBase
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
		public PSAhysRotationWorldVector()
		{
			throw null;
		}
	}
}
