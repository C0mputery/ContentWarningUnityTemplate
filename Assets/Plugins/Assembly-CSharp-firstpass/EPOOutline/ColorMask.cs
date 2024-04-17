using System;

namespace EPOOutline
{
	[Flags]
	public enum ColorMask
	{
		None = 0,
		R = 1,
		G = 2,
		B = 4,
		A = 8
	}
}
