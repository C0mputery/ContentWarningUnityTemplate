using System;

namespace Photon.Voice
{
	public interface IProcessor<T> : IDisposable
	{
		T[] Process(T[] buf);
	}
}
