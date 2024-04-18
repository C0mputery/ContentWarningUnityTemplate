using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys.Bursted.Handlers;

namespace pworld.Scripts.PPhys.Bursted.Springs
{
	public class PSpringLocal : PBurstSpringWorkerPosition
	{
		public Vector3 target;

		public Transform inLocalOf;

		public override Vector3 Target
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PSpringLocal()
		{

		}
	}
}
