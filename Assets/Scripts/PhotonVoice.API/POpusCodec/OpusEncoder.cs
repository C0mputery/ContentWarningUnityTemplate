using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using POpusCodec.Enums;
using Photon.Voice;

namespace POpusCodec
{
	public class OpusEncoder : IDisposable
	{
		public const int BitrateMax = -1;

		private IntPtr handle;

		private const int RecommendedMaxPacketSize = 4000;

		private int frameSamples;

		private SamplingRate inputSamplingRate;

		private Channels channels;

		private readonly byte[] writePacket;

		private static readonly ArraySegment<byte> EmptyBuffer;

		private Delay _encoderDelay;

		public static Dictionary<IntPtr, OpusEncoder> handles;

		private byte[] bufOut;

		public Action<ArraySegment<byte>, FrameFlags> Output;

		public SamplingRate InputSamplingRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Channels InputChannels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Delay EncoderDelay
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

		public int FrameSizePerChannel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Bitrate
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

		public Bandwidth MaxBandwidth
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

		public Complexity Complexity
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

		public int ExpectedPacketLossPercentage
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

		public SignalHint SignalHint
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

		public ForceChannels ForceChannels
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

		public bool UseInbandFEC
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

		public int PacketLossPercentage
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

		public bool UseUnconstrainedVBR
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

		public bool DtxEnabled
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
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[MonoPInvokeCallback(typeof(Action<IntPtr, IntPtr, int>))]
		public static void DataCallbackStatic(IntPtr handle, IntPtr p, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void dataCallback(IntPtr p, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Encode(float[] pcmSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Encode(short[] pcmSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static OpusEncoder()
		{
			throw null;
		}
	}
}
