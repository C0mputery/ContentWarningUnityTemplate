using System;
using System.Collections;
using System.Collections.Generic;

namespace Photon.Voice
{
	public interface IDeviceEnumerator : IDisposable, IEnumerable<DeviceInfo>, IEnumerable
	{
		bool IsSupported { get; }

		Action OnReady { set; }

		string Error { get; }

		void Refresh();
	}
}
