using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class VideoCamera : ItemInstanceBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRestartRecordingDelayed_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoCamera _003C_003E4__this;

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
		public _003CRestartRecordingDelayed_003Ed__31(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUnlockCamera_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoCamera _003C_003E4__this;

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
		public _003CUnlockCamera_003Ed__30(int _003C_003E1__state)
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

	public bool recordEvenWhenNotMine;

	public Camera m_camera;

	public Transform flipPos;

	private Vector3 startCameraLocalPos;

	[SerializeField]
	private Canvas m_cameraUI;

	[SerializeField]
	private GameObject m_recordingUI;

	[SerializeField]
	private MeshRenderer m_cameraScreen;

	[SerializeField]
	private float m_cameraFov;

	[SerializeField]
	private float m_zoom;

	private float m_zoomLevel;

	private float m_contentPollingTimer;

	private float m_contentPollingCooldown;

	public GameObject[] disableWhenRecordingNormal;

	public GameObject[] disableWhenRecordingFlipped;

	public GameObject[] disableWhenRecording;

	public GameObject[] enableWhenRecording;

	private bool m_lastCheckWasRecording;

	private bool m_lastCheckWasFlipped;

	private bool m_lastRecordEvenWhenNotMine;

	private VideoInfoEntry m_recorderInfoEntry;

	private ItemInstanceData m_instanceData;

	private PhotonView m_playerView;

	private Clip m_clip;

	private static readonly int BaseMap;

	private ContentBuffer contentBuffer;

	private bool m_blockCameraInput;

	private float timeSinceHeld;

	public SFX_Instance findCameraSounds;

	private float timeSinceBeep;

	public Light findMeLight;

	public float bleepInterval;

	public float upLength;

	public float dontBeepUntil;

	public bool recording
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool HasFilmLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CUnlockCamera_003Ed__30))]
	private IEnumerator UnlockCamera()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CRestartRecordingDelayed_003Ed__31))]
	private IEnumerator RestartRecordingDelayed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RestartRecording(PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoFindMeBlipp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartRecording(Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateRenderTexture()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopRecording()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoCamera()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VideoCamera()
	{
		throw null;
	}
}
