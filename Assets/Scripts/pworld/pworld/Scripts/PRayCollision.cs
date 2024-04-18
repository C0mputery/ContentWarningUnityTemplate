using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PRayCollision : MonoBehaviour
	{
		private bool collidedThisFrame;

		private PRaycastHit lastHit;

		private Vector3 lastPosition;

		public Action<PRaycastHit> OnCollision;

		public Action<PRaycastHit> OnCollisionLate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CollidedThisFrame(out PRaycastHit hit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckFirst(out PRaycastHit hitInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool Check(out PRaycastHit hitInfo, LayerMask mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PRayCollision()
		{

		}
	}
}
