using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice.Unity
{
	[Serializable]
	public struct AndroidAudioInParameters
	{
		public bool EnableAEC;

		public bool EnableAGC;

		public bool EnableNS;

		public static AndroidAudioInParameters Default;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AndroidAudioInParameters()
		{
			throw null;
		}
	}
}
