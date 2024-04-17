using System;

namespace Photon.Voice
{
	public interface IDecoderDirect<B> : IDecoder, IDisposable
	{
		Action<B> Output { get; set; }
	}
}
