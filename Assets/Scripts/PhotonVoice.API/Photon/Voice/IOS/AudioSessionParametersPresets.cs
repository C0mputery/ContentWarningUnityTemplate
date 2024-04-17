using System.Runtime.CompilerServices;

namespace Photon.Voice.IOS
{
	public static class AudioSessionParametersPresets
	{
		public static AudioSessionParameters Game;

		public static AudioSessionParameters VoIP;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AudioSessionParametersPresets()
		{
			throw null;
		}
	}
}
