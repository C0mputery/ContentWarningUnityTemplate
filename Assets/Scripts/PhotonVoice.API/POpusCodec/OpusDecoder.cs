using System;
using System.Runtime.CompilerServices;
using POpusCodec.Enums;
using Photon.Voice;

namespace POpusCodec
{
	public class OpusDecoder<T> : IDisposable
	{
		private const bool UseInbandFEC = true;

		protected Action<FrameOut<T>> output;

		protected bool TisFloat;

		protected int sizeofT;

		protected FrameOut<T> frameOut;

		protected IntPtr handle;

		protected int channels;

		protected int frameSamples;

		protected static readonly T[] EmptyBuffer;

		private T[] buffer;

		private bool prevPacketInvalid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpusDecoder(Action<FrameOut<T>> output, SamplingRate outputSamplingRateHz, Channels channels, int frameSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void decodePacket(FrameBuffer data, int decodeFEC, int channels, bool endOfStream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void procOutput(T[] buffer, bool endOfStream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DecodePacket(ref FrameBuffer packetData, bool endOfStream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static OpusDecoder()
		{
			throw null;
		}
	}
}
