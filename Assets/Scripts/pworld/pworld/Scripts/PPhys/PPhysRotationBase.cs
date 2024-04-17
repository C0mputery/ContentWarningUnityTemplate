using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys
{
	public abstract class PPhysRotationBase : PPhysSpringBase
	{
		public abstract Vector3 TargetUp { get; }

		public abstract Quaternion CurrentRotation { get; set; }

		public override Vector3 Current
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
		protected override void PhysicsStep(float dt)
		{
			throw null;
		}

		public abstract void Rotate(Vector3 dRot);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PPhysRotationBase()
		{
			throw null;
		}
	}
}
