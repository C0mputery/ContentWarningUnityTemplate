using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys
{
	public class PPhysScaleAround : PPhysSpringBase
	{
		public Transform around;

		public Transform affected;

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
		public PPhysScaleAround()
		{

		}
	}
}
