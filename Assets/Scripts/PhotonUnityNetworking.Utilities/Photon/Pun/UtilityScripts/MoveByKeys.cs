using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun.UtilityScripts
{
	[RequireComponent(typeof(PhotonView))]
	public class MoveByKeys : MonoBehaviourPun
	{
		public float Speed;

		public float JumpForce;

		public float JumpTimeout;

		private bool isSprite;

		private float jumpingTime;

		private Rigidbody body;

		private Rigidbody2D body2d;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MoveByKeys()
		{

		}
	}
}
