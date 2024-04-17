using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Serialization;

namespace Photon.Voice.Unity
{
	[DisallowMultipleComponent]
	public class VoiceConnection : ConnectionHandler
	{
		public const int ChannelAudio = 1;

		public const int ChannelVideo = 2;

		private VoiceComponentImpl voiceComponentImpl;

		private const string PlayerPrefsKey = "VoiceCloudBestRegion";

		private LoadBalancingTransport client;

		private SupportLogger supportLoggerComponent;

		[SerializeField]
		private bool runInBackground;

		[SerializeField]
		private int statsResetInterval;

		private int nextStatsTickCount;

		private float statsReferenceTime;

		private int referenceFramesLost;

		private int referenceFramesReceived;

		[SerializeField]
		private GameObject speakerPrefab;

		private List<RemoteVoiceLink> cachedRemoteVoices;

		[SerializeField]
		[FormerlySerializedAs("PrimaryRecorder")]
		private Recorder primaryRecorder;

		[SerializeField]
		[Tooltip("Use primary recorder directly by Voice Client")]
		private bool usePrimaryRecorder;

		[SerializeField]
		[Tooltip("Use the protocol compatible with Photon Voice C++ API")]
		private bool cppCompatibilityMode;

		private List<Speaker> linkedSpeakers;

		private List<Recorder> recorders;

		public AppSettings Settings;

		public virtual bool AlwaysUsePrimaryRecorder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected ILogger Logger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public VoiceLogger VoiceLogger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public new LoadBalancingTransport Client
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public VoiceClient VoiceClient
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public ClientState ClientState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float FramesReceivedPerSecond
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public float FramesLostPerSecond
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public float FramesLostPercent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public GameObject SpeakerPrefab
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Recorder PrimaryRecorder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool UsePrimaryRecorder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string BestRegionSummaryInPreferences
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public event Action<Speaker> SpeakerLinked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event Action<RemoteVoiceLink> RemoteVoiceAdded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ConnectUsingSettings(AppSettings overwriteSettings = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AddSpeaker(Speaker speaker, object userData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Speaker InstantiateSpeakerForRemoteVoice(int playerId, byte voiceId, object userData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Speaker InstantiateSpeakerPrefab(GameObject parent, bool destroyOnRemove)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnVoiceStateChanged(ClientState fromState, ClientState toState)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CalcStatistics()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LinkSpeaker(Speaker speaker, RemoteVoiceLink remoteVoice)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AddRecorder(Recorder rec)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveRecorder(Recorder rec)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnOperationResponseReceived(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VoiceConnection()
		{
			throw null;
		}
	}
}
