using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Handlers;

namespace pworld.Scripts.PPhys.Bursted.Rotators
{
	public class PRotatorLocal : PBurstSpringWorkerRotation
	{
		public Vector3 mForward;

		public Vector3 mUp;

		public Transform parent;

		public override Quaternion Target
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PRotatorLocal()
		{

		}
	}
}
