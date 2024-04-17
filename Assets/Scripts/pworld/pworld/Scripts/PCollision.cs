using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public abstract class PCollision : MonoBehaviour
	{
		public Action<RaycastHit> OnCollision;

		public Action<RaycastHit> OnCollisionLate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PCollision()
		{
			throw null;
		}
	}
}
