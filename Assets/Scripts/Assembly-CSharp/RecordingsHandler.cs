using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Zorro.Core;
using Zorro.PhotonUtility;
using Zorro.Recorder;

public class RecordingsHandler : RetrievableSingleton<RecordingsHandler>
{
	[CompilerGenerated]
	private sealed class _003CCheckIfClipIsComplete_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Clip clip;

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
		public _003CCheckIfClipIsComplete_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CEncode_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Clip clip;

		public RecordingsHandler _003C_003E4__this;

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
		public _003CEncode_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CShareClipJob_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordingsHandler _003C_003E4__this;

		public Clip clip;

		public bool isReRequest;

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
		public _003CShareClipJob_003Ed__18(int _003C_003E1__state)
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

	private Dictionary<VideoHandle, CameraRecording> m_recordings;

	private BidirectionalDictionary<Guid, VideoHandle> m_camerasCurrentRecording;

	private BidirectionalDictionary<int, VideoHandle> m_playersRecording;

	private ListenerHandle startRecordingHandle;

	private ListenerHandle stopRecordingHandle;

	private ListenerHandle clipEncodedHandle;

	private ListenerHandle activateNextSharingJobHandle;

	private ListenerHandle sendClipCompletedHandle;

	private ListenerHandle reRequestClipHandle;

	private List<VideoClipShareJob> m_sharingQueue;

	private VideoClipShareJob m_currentJob;

	private FfmpegEncoder m_encoder;

	private PhotonSendVideoHandler m_sendVideoHandler;

	private Dictionary<ClipID, int> m_clipRequestCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExtractRecording(CameraRecording recording)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CShareClipJob_003Ed__18))]
	private IEnumerator ShareClipJob(Clip clip, bool isReRequest)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CEncode_003Ed__19))]
	private IEnumerator Encode(Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStartRecording(StartRecordingCommandPackage package)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CameraRecording CreateNewRecording(VideoHandle entryVideoID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStopRecording(StopRecordingCommandPackage package)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStopRecording(Guid instanceDataID, bool validClip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartRecording(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int FindFreePlayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StopRecording(ItemInstanceData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<VideoHandle, CameraRecording> GetRecordings()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BidirectionalDictionary<Guid, VideoHandle> GetCamerasCurrentRecording()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BidirectionalDictionary<int, VideoHandle> GetPlayersRecording()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDirectory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddClipToShareQueue(AddClipToShareQueuePackage package)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<VideoClipShareJob> GetSharingQueue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static VideoClipShareJob GetCurrentSharingJob()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnActivateNextSharingJob(ActivateNextSharingJobPackage package)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendIsComplete(SendClipCompletedPackage package)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReRequestClip(ReRequestClipPackage obj)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CCheckIfClipIsComplete_003Ed__37))]
	private IEnumerator CheckIfClipIsComplete(Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RecievedClip(VideoHandle chunkVideoID, ClipID chunkClipID, ContentBuffer contentBuffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetRecording(VideoHandle tVideoID, out CameraRecording recording)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetRecordingPath(VideoHandle videoHandle, out string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearRecordings()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnRemoved()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RecordingsHandler()
	{

	}
}
