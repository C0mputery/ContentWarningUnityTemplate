using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public class PhotonTransformViewScaleControl
	{
		private PhotonTransformViewScaleModel m_Model;

		private Vector3 m_NetworkScale;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel model)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetNetworkScale()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetScale(Vector3 currentScale)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(Vector3 currentScale, PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}
	}
}
