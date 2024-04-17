using System;

namespace EPOOutline
{
	[Flags]
	public enum OutlinableDrawingMode
	{
		Normal = 1,
		ZOnly = 2,
		GenericMask = 4,
		Obstacle = 8,
		Mask = 0x10
	}
}
