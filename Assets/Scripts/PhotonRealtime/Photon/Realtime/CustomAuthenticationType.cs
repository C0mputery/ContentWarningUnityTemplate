using System;

namespace Photon.Realtime
{
	public enum CustomAuthenticationType : byte
	{
		Custom = 0,
		Steam = 1,
		Facebook = 2,
		Oculus = 3,
		PlayStation4 = 4,
		[Obsolete("Use PlayStation4 or PlayStation5 as needed")]
		PlayStation = 4,
		Xbox = 5,
		Viveport = 10,
		NintendoSwitch = 11,
		PlayStation5 = 12,
		[Obsolete("Use PlayStation4 or PlayStation5 as needed")]
		Playstation5 = 12,
		Epic = 13,
		FacebookGaming = 15,
		None = byte.MaxValue
	}
}
