using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Zorro.PhotonUtility;

public class PhotonSendVideoHandler : RetrievableSingleton<PhotonSendVideoHandler>
{
	[CompilerGenerated]
	private sealed class _003CSendVideoChunks_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<byte[]> videoChunks;

		public ClipID clipID;

		public VideoHandle videoID;

		public ContentBuffer contentBuffer;

		public PhotonSendVideoHandler _003C_003E4__this;

		public bool isReRequest;

		private ushort _003CchunkIndex_003E5__2;

		private List<byte[]>.Enumerator _003C_003E7__wrap2;

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
		public _003CSendVideoChunks_003Ed__14(int _003C_003E1__state)
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
		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CSendVideoThroughPhoton_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Clip clipToSend;

		public PhotonSendVideoHandler _003C_003E4__this;

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
		public _003CSendVideoThroughPhoton_003Ed__13(int _003C_003E1__state)
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

	private readonly string VIDEO_EXTENSION;

	private const float TIMER_PER_PACKAGE = 0.5f;

	private const int BYTES_PER_CHUNK = 30000;

	private string PATH_TO_VIDEO;

	private ListenerHandle m_sendChunkListenHandle;

	private Dictionary<ClipID, VideoChunk> m_VideoChunkDic;

	private bool m_UseSteamNetwork;

	private SteamLobbyHandler m_SteamLobby;

	private bool m_Sending;

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
	private void InitSendVideoHandler()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CSendVideoThroughPhoton_003Ed__13))]
	public IEnumerator SendVideoThroughPhoton(Clip clipToSend, bool isReRequest)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CSendVideoChunks_003Ed__14))]
	private IEnumerator SendVideoChunks(List<byte[]> videoChunks, ClipID clipID, VideoHandle videoID, ContentBuffer contentBuffer, bool isReRequest)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecieveClipChunk(SendVideoChunkPackage package)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TempSaveReceivedVideo(VideoChunk chunk)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PhotonSendVideoHandler()
	{

	}
}
