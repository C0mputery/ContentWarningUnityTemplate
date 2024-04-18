using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun.UtilityScripts
{
	[RequireComponent(typeof(PhotonView))]
	public class CullingHandler : MonoBehaviour, IPunObservable
	{
		private int orderIndex;

		private CullArea cullArea;

		private List<byte> previousActiveCells;

		private List<byte> activeCells;

		private PhotonView pView;

		private Vector3 lastPosition;

		private Vector3 currentPosition;

		private float timeSinceUpdate;

		private float timeBetweenUpdatesMin;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
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
		private void OnGUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool HaveActiveCellsChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateInterestGroups()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CullingHandler()
		{

		}
	}
}
