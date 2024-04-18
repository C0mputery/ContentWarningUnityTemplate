using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun.UtilityScripts
{
	[RequireComponent(typeof(PhotonView))]
	public class SmoothSyncMovement : MonoBehaviourPun, IPunObservable
	{
		public float SmoothingDelay;

		private Vector3 correctPlayerPos;

		private Quaternion correctPlayerRot;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmoothSyncMovement()
		{

		}
	}
}
