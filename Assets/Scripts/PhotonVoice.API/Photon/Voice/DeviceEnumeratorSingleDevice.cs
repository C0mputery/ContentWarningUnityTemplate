using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class DeviceEnumeratorSingleDevice : DeviceEnumeratorBase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeviceEnumeratorSingleDevice(ILogger logger, string deviceName) : base(null)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Refresh()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}
	}
}
