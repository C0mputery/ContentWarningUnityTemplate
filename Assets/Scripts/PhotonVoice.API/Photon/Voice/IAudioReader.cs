using System;

namespace Photon.Voice
{
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioDesc
	{
	}
}
