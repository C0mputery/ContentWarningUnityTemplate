using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class VoiceClient : IDisposable
	{
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		public struct CreateOptions
		{
			public byte VoiceIDMin;

			public byte VoiceIDMax;

			public static CreateOptions Default;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static CreateOptions()
			{
				throw null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_RemoteVoiceInfos_003Ed__82 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private RemoteVoiceInfo _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VoiceClient _003C_003E4__this;

			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator _003C_003E7__wrap1;

			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> _003CplayerVoices_003E5__3;

			private Dictionary<byte, RemoteVoice>.Enumerator _003C_003E7__wrap3;

			RemoteVoiceInfo IEnumerator<RemoteVoiceInfo>.Current
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
			public _003Cget_RemoteVoiceInfos_003Ed__82(int _003C_003E1__state)
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
			private void _003C_003Em__Finally2()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<RemoteVoiceInfo> IEnumerable<RemoteVoiceInfo>.GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw null;
			}
		}

		internal IVoiceTransport transport;

		internal ILogger logger;

		private int prevRtt;

		private Dictionary<Codec, int> remoteVoiceDelayFrames;

		private byte voiceIDMin;

		private byte voiceIDMax;

		private byte voiceIdLast;

		private Dictionary<byte, LocalVoice> localVoices;

		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		private Dictionary<int, Dictionary<byte, RemoteVoice>> remoteVoices;

		private Random rnd;

		public bool ThreadingEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public int EventsLost
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesLost
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesFragPart
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesRecovered
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesMiss
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesLate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesLateUsed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int FramesReceived
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

		public int FramesReceivedFEC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesTryFEC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesReceivedFragments
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesReceivedFragmented
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public int FramesSent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int FramesSentBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int RoundTripTime
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

		public int RoundTripTimeVariance
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

		public bool SuppressInfoDuplicateWarning
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public int DebugLostPercent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public IEnumerable<LocalVoice> LocalVoices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[IteratorStateMachine(typeof(_003Cget_RemoteVoiceInfos_003Ed__82))]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogSpacingProfiles()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogStats()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRemoteVoiceDelayFrames(Codec codec, int delayFrames)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VoiceClient(IVoiceTransport transport, ILogger logger, CreateOptions opt = default(CreateOptions))
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Service()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private LocalVoice createLocalVoice(int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId, VoiceCreateOptions options = default(VoiceCreateOptions))
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions options = default(VoiceCreateOptions))
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocalVoice CreateLocalVoiceAudioFromSource(VoiceInfo voiceInfo, IAudioDesc source, AudioSampleType sampleType, int channelId, VoiceCreateOptions options = default(VoiceCreateOptions))
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte idInc(byte id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte getNewVoiceId()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveLocalVoice(LocalVoice voice)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void clearRemoteVoices()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void clearRemoteVoicesInChannel(int channelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void clearRemoteVoicesInChannelForPlayer(int channelId, int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onJoinChannel(int channelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onJoinAllChannels()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onLeaveChannel(int channel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onLeaveAllChannels()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onPlayerJoin(int channelId, int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onPlayerJoin(int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onPlayerLeave(int channelId, int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onPlayerLeave(int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onVoiceInfo(int channelId, int playerId, byte voiceId, byte eventNumber, VoiceInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onVoiceRemove(int playerId, byte[] voiceIds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onFrame(int playerId, byte voiceId, byte evNumber, ref FrameBuffer receivedBytes, bool isLocalPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string channelStr(int channelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string playerStr(int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
