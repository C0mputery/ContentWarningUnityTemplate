using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class LocalVoice : IDisposable
	{
		public const int DATA_POOL_CAPACITY = 50;

		private bool transmitEnabled;

		private bool debugEchoMode;

		protected int[] targetPlayers_;

		protected VoiceInfo info;

		protected IEncoder encoder;

		internal byte id;

		internal int channelId;

		internal byte evNumber;

		protected VoiceClient voiceClient;

		protected bool threadingEnabled;

		protected ArraySegment<byte> configFrame;

		protected volatile bool disposed;

		protected object disposeLock;

		private const int NO_TRANSMIT_TIMEOUT_MS = 100;

		private int lastTransmitTime;

		private const int FEC_INFO_SIZE = 5;

		private byte[] fecBuffer;

		private FrameFlags fecFlags;

		private byte fecFrameNumber;

		private int fecTotSize;

		private int fecMaxSize;

		private byte fecCnt;

		internal Dictionary<byte, int> eventTimestamps;

		private SpacingProfile sendSpacingProfile;

		public VoiceInfo Info
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool TransmitEnabled
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

		public bool IsCurrentlyTransmitting
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int FramesSent
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

		public int FramesSentFragmented
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

		public int FramesSentFragments
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

		public int FramesSentBytes
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

		public bool Reliable
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

		public bool Encrypt
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

		public bool Fragment
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

		public int FEC
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

		public IServiceable LocalUserServiceable
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

		[Obsolete("Use InterestGroup.")]
		public byte Group
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

		public byte InterestGroup
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

		public bool DebugEchoMode
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

		public int[] TargetPlayers
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

		public string SendSpacingProfileDump
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int SendSpacingProfileMax
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte ID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte EvNumber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected string shortName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string LogPrefix
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected bool isJoined
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendSpacingProfileStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocalVoice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocalVoice(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, int channelId, VoiceCreateOptions opt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void service()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool targetExits(bool targetMe, int[] targetPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void onJoinChannel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void onPlayerJoin(int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void sendVoiceInfoAndConfigFrame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string getTargetStr(bool targetMe, int[] targetPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void sendVoiceInfoAndConfigFrame(bool targetMe, int[] targetPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void sendVoiceRemove()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void sendVoiceRemove(bool targetMe, int[] targetPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void sendFrame(ArraySegment<byte> compressed, FrameFlags flags)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void sendFrame0(ArraySegment<byte> compressed, FrameFlags flags, bool targetMe, int[] targetPlayers, byte interestGroup, bool reliable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void resetFEC()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sendFrameEvent(ArraySegment<byte> data, FrameFlags flags, SendFrameParams sendFramePar)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveSelf()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}
	}
}
