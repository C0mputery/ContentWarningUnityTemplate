using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "CameraUpgradeItem", menuName = "W/CameraUpgradeItem", order = -1)]
public class CameraUpgradeItem : Item
{
	public enum CameraUpgradeType
	{
		Invalid = 0,
		Zoom = 1,
		Fov = 2,
		Lens = 3
	}

	public byte upgradeId;

	public CameraUpgradeType UpgradeType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraUpgradeItem()
	{

	}
}
