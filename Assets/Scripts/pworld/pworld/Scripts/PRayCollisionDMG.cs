using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PRayCollisionDMG : MonoBehaviour
	{
		public float damage;

		private PRayCollision collision_g;

		public List<Func<PRaycastHit, bool>> DmgCriterias;

		public Action OnDmg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckCriterias(PRaycastHit other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoDmg(PRaycastHit obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PRayCollisionDMG()
		{

		}
	}
}
