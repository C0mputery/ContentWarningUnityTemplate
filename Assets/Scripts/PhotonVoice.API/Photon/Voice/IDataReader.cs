using System;

namespace Photon.Voice
{
	public interface IDataReader<T> : IDisposable
	{
		bool Read(T[] buffer);
	}
}
