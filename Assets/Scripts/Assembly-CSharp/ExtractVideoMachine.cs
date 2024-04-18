using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using Zorro.Core;

public class ExtractVideoMachine : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CExtractVideo_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExtractVideoMachine _003C_003E4__this;

		public VideoHandle handle;

		private float _003Ct_003E5__2;

		private bool _003Csuccess_003E5__3;

		private CameraRecording _003Crecording_003E5__4;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CExtractVideo_003Ed__30(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public Item m_flashCardItem;

	public GameObject m_extractionStateUI;

	public GameObject m_successStateUI;

	public GameObject m_failedStateUI;

	private byte m_currentCameraID;

	private Dictionary<int, bool> m_arePlayersDone;

	private Coroutine m_extractCoroutine;

	private VideoHandle m_videoHandle;

	private PhotonView m_photonView;

	public ExtractVideoItemDetector Detector;

	public ExtractVideoStationHatch Hatch;

	public CDRom Rom;

	public VideoExtractMachineStateMachine StateMachine;

	public Transform m_discRespawnPoint;

	public Optionable<VideoHandle> m_hasCDInRom;

	public bool AlreadyExtracting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

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
	private void OnSleep()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Item> CheckForItems()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncHatchState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_SyncHatch(bool state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartExtract(VideoHandle tVideoID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_StartExtract(byte[] buffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_Failed(int score, int money)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_Success()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CExtractVideo_003Ed__30))]
	private IEnumerator ExtractVideo(VideoHandle handle)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_ExtractDone(int playerID, bool success)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_SetRom(byte[] buffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncCDRomState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_ComState(bool state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPickupCD(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_PickupCD(int playerID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_RemoveCD()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unlock()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractVideoMachine()
	{

	}
}
