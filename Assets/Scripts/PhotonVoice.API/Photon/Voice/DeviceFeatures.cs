using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class DeviceFeatures
	{
		internal static DeviceFeatures Default;

		public CameraFacing CameraFacing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeviceFeatures()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeviceFeatures(CameraFacing facing)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DeviceFeatures()
		{
			throw null;
		}
	}
}
