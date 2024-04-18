using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys
{
	public class PPhysPositional : PPhysSpringBase
	{
		public Transform transTarget;

		public override Vector3 Target
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
		public override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PPhysPositional()
		{

		}
	}
}
