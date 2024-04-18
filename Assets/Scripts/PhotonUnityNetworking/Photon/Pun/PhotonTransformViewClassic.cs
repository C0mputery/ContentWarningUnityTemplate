using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	[AddComponentMenu("Photon Networking/Photon Transform View Classic")]
	public class PhotonTransformViewClassic : MonoBehaviourPun, IPunObservable
	{
		[HideInInspector]
		public PhotonTransformViewPositionModel m_PositionModel;

		[HideInInspector]
		public PhotonTransformViewRotationModel m_RotationModel;

		[HideInInspector]
		public PhotonTransformViewScaleModel m_ScaleModel;

		private PhotonTransformViewPositionControl m_PositionControl;

		private PhotonTransformViewRotationControl m_RotationControl;

		private PhotonTransformViewScaleControl m_ScaleControl;

		private PhotonView m_PhotonView;

		private bool m_ReceivedNetworkUpdate;

		private bool m_firstTake;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePosition()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateRotation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateScale()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSynchronizedValues(Vector3 speed, float turnSpeed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransformViewClassic()
		{

		}
	}
}
