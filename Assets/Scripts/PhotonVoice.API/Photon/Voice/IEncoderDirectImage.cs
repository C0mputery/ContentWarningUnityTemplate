using System;

namespace Photon.Voice
{
	public interface IEncoderDirectImage : IEncoderDirect<ImageBufferNative>, IEncoder, IDisposable
	{
		ImageFormat ImageFormat { get; }
	}
}
