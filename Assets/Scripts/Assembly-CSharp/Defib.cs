using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Defib : ItemInstanceBehaviour
{
	public Light m_light;

	public MeshRenderer lightBeam;

	public MeshRenderer brightPart;

	public GameObject trigger;

	public BatteryDisplay m_batteryDisplay;

	public float maxCharge;

	public int maxCharges;

	public float attackForce;

	public float onTime;

	public float elapsedOn;

	private BatteryEntry m_batteryEntry;

	private OnOffEntry m_onOffEntry;

	private Player playerHoldingItem;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDefibTrigger(Collider other, bool debug = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Defib()
	{

	}
}
