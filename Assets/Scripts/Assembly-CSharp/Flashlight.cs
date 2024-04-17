using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Flashlight : ItemInstanceBehaviour
{
	public Light m_light;

	public MeshRenderer lightBeam;

	public MeshRenderer brightPart;

	public GameObject trigger;

	public BatteryDisplay m_batteryDisplay;

	private BatteryEntry m_batteryEntry;

	private OnOffEntry m_onOffEntry;

	public float maxCharge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Flashlight()
	{
		throw null;
	}
}
