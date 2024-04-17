using System;

namespace Photon.Voice
{
	public interface IAudioDesc : IDisposable
	{
		int SamplingRate { get; }

		int Channels { get; }

		string Error { get; }
	}
}
