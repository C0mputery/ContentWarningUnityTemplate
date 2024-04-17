using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(menuName = "Database/CameraUpgradesDatabase", order = 9999, fileName = "CameraUpgradesDatabase")]
public class CameraUpgradesDatabase : ObjectDatabaseAsset<CameraUpgradesDatabase, CameraUpgradeItem>
{
	public Dictionary<CameraUpgradeItem.CameraUpgradeType, List<CameraUpgradeItem>> UpgradeTypeToItemsDic;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetItemFromUpgradeID(byte id, out CameraUpgradeItem item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraUpgradesDatabase()
	{
		throw null;
	}
}
