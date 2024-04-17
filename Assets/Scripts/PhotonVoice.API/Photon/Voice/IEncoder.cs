using System;

namespace Photon.Voice
{
	public interface IEncoder : IDisposable
	{
		string Error { get; }

		Action<ArraySegment<byte>, FrameFlags> Output { set; }

		ArraySegment<byte> DequeueOutput(out FrameFlags flags);

		void EndOfStream();

		I GetPlatformAPI<I>() where I : class;
	}
}
