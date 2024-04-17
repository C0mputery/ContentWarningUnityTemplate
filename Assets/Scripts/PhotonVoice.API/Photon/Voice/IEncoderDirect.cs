using System;

namespace Photon.Voice
{
	public interface IEncoderDirect<B> : IEncoder, IDisposable
	{
		void Input(B buf);
	}
}
