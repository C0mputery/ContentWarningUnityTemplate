using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class AudioInEnumeratorNotSupported : DeviceEnumeratorNotSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioInEnumeratorNotSupported(ILogger logger) : base(null, null)
		{

		}
	}
}
