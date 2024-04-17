using System;

namespace Photon.Voice
{
	public interface IDecoder : IDisposable
	{
		string Error { get; }

		void Open(VoiceInfo info);

		void Input(ref FrameBuffer buf);
	}
}
