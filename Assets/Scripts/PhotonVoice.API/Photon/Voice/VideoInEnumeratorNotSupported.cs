using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class VideoInEnumeratorNotSupported : DeviceEnumeratorNotSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public VideoInEnumeratorNotSupported(ILogger logger) : base(null, null)
		{

		}
	}
}
