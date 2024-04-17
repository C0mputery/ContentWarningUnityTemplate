using System;

namespace Photon.Voice
{
	public interface IAudioPusher<T> : IAudioDesc, IDisposable
	{
		void SetCallback(Action<T[]> callback, ObjectFactory<T[], int> bufferFactory);
	}
}
