using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Handlers;

namespace pworld.Scripts.PPhys.Bursted.Rotators
{
	public class PRotatorLookAt : PBurstSpringWorkerRotation
	{
		public Transform lookAt;

		public override Quaternion Target
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual Vector3 LookAtDir
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual Vector3 TargetUp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PRotatorLookAt()
		{

		}
	}
}
