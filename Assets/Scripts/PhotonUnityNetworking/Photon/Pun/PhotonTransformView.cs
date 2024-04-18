using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	[AddComponentMenu("Photon Networking/Photon Transform View")]
	[HelpURL("https://doc.photonengine.com/en-us/pun/v2/gameplay/synchronization-and-state")]
	public class PhotonTransformView : MonoBehaviourPun, IPunObservable
	{
		private float m_Distance;

		private float m_Angle;

		private Vector3 m_Direction;

		private Vector3 m_NetworkPosition;

		private Vector3 m_StoredPosition;

		private Quaternion m_NetworkRotation;

		public bool m_SynchronizePosition;

		public bool m_SynchronizeRotation;

		public bool m_SynchronizeScale;

		[Tooltip("Indicates if localPosition and localRotation should be used. Scale ignores this setting, and always uses localScale to avoid issues with lossyScale.")]
		public bool m_UseLocal;

		private bool m_firstTake;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransformView()
		{

		}
	}
}
