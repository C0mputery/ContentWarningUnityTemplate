using System;

namespace EPOOutline
{
	[Flags]
	public enum RenderersAddingMode
	{
		All = -1,
		None = 0,
		MeshRenderer = 1,
		SkinnedMeshRenderer = 2,
		SpriteRenderer = 4,
		Others = 0x1000
	}
}
