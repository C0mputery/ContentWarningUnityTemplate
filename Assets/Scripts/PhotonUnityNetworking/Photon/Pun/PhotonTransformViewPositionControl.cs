using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public class PhotonTransformViewPositionControl
	{
		private PhotonTransformViewPositionModel m_Model;

		private float m_CurrentSpeed;

		private double m_LastSerializeTime;

		private Vector3 m_SynchronizedSpeed;

		private float m_SynchronizedTurnSpeed;

		private Vector3 m_NetworkPosition;

		private Queue<Vector3> m_OldNetworkPositions;

		private bool m_UpdatedPositionAfterOnSerialize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel model)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 GetOldestStoredNetworkPosition()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSynchronizedValues(Vector3 speed, float turnSpeed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 UpdatePosition(Vector3 currentPosition)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetNetworkPosition()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetExtrapolatedPositionOffset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeData(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeserializeData(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}
	}
}
