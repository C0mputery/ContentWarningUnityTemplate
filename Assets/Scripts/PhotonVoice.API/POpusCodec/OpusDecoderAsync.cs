using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using POpusCodec.Enums;
using Photon.Voice;

namespace POpusCodec
{
	public class OpusDecoderAsync<T> : OpusDecoder<T>
	{
		protected static Dictionary<IntPtr, OpusDecoderAsync<T>> handles;

		private float[] bufOutFloat;

		private short[] bufOutShort;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[MonoPInvokeCallback(typeof(Action<IntPtr, IntPtr, int, bool>))]
		public static void DataCallbackStatic(IntPtr handle, IntPtr p, int count, bool endOfStream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpusDecoderAsync(Action<FrameOut<T>> output, SamplingRate outputSamplingRateHz, Channels numChannels, int frameDurationSamples) : base(null, SamplingRate.Sampling08000, Channels.Stereo, 69)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void dataCallback(IntPtr p, int count, bool endOfStream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static OpusDecoderAsync()
		{
			throw null;
		}
	}
}
