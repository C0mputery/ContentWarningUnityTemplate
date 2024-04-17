using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class DecoderConfigFrame : IDisposable
	{
		private ILogger logger;

		private IDecoder decoder;

		private FrameBuffer configFrame;

		private bool configFrameDecoded;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecoderConfigFrame(ILogger logger, IDecoder decoder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryConfigure(ref FrameBuffer buf, bool decoderReady)
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
