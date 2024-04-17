using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Photon.Voice
{
	internal class RemoteVoice : IDisposable
	{
		private class FragmentedPoolSlot : IDisposable
		{
			private byte[] buf;

			public bool IsFree
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

			public byte[] Buf
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

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FragmentedPoolSlot()
			{
				throw null;
			}
		}

		internal RemoteVoiceOptions options;

		internal int channelId;

		private int playerId;

		private byte voiceId;

		protected bool threadingEnabled;

		private volatile bool disposed;

		private object disposeLock;

		private volatile int receiving;

		private volatile bool decoding;

		private SpacingProfile receiveSpacingProfile;

		private VoiceClient voiceClient;

		private FrameBuffer[] eventQueue;

		private int[] eventQueueLock;

		private byte frameWritePos;

		private byte frameReadPos;

		private byte eventReadPos;

		private AutoResetEvent frameQueueReady;

		private int flushingFrameNum;

		private FrameBuffer nullFrame;

		private ConcurrentQueue<FrameBuffer> configFrameQueue;

		private bool started;

		private FragmentedPoolSlot[] fragmentedPool;

		private FrameBuffer[] fecQueue;

		private int[] fecQueueLock;

		private byte[] fecXoredEvents;

		private const int FEC_EVENT_TIMEOUT_INF = 127;

		private byte fecEventTimeout;

		private const int QUEUE_CLEAR_LAG = 64;

		private bool fragmentDetected;

		internal VoiceInfo Info
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

		internal int DelayFrames
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

		private string shortName
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

		public string ReceiveSpacingProfileDump
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int ReceiveSpacingProfileMax
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveSpacingProfileStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void receiveBytes(ref FrameBuffer receivedBytes, byte evNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void decodeQueue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processLostEvent(byte lostEvNum, ref FrameBuffer lostEv)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool recoverLostEvent(byte lostEvNum, ref FrameBuffer lostEv, byte fecEvNum, ref FrameBuffer fecEv)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte processFrame(byte begEvNum)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void decodeThread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void removeAndDispose()
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
