using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Serialization;

public class PartyPopper : ItemInstanceBehaviour
{
	[FormerlySerializedAs("explodedGoopPref")]
	public GameObject confettiPref;

	private readonly float timeNotHeld;

	private StashAbleEntry stashAbleEntry;

	private OnOffEntry usedEntry;

	public GameObject chargesLeftGO;

	private bool wasUsedOnConfig;

	private bool wasConfig;

	public Transform dir;

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
	public PartyPopper()
	{

	}
}
