using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public class PhotonTransformViewRotationControl
	{
		private PhotonTransformViewRotationModel m_Model;

		private Quaternion m_NetworkRotation;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel model)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quaternion GetNetworkRotation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quaternion GetRotation(Quaternion currentRotation)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(Quaternion currentRotation, PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}
	}
}
