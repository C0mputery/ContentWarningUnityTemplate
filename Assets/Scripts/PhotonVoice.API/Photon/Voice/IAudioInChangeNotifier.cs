using System;

namespace Photon.Voice
{
	public interface IAudioInChangeNotifier : IDisposable
	{
		bool IsSupported { get; }

		string Error { get; }
	}
}
