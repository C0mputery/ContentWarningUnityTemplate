using System;

namespace Sirenix.OdinInspector
{
	[Flags]
	public enum PrefabKind
	{
		None = 0,
		InstanceInScene = 1,
		InstanceInPrefab = 2,
		Regular = 4,
		Variant = 8,
		NonPrefabInstance = 0x10,
		PrefabInstance = 3,
		PrefabAsset = 0xC,
		PrefabInstanceAndNonPrefabInstance = 0x13,
		All = 0x1F
	}
}
