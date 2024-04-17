using System.Runtime.CompilerServices;
using DefaultNamespace;
using Photon.Pun;

public class ItemLostDisc : ItemInstanceBehaviour
{
	public float timeToTeleport;

	private ExtractVideoMachine machine;

	private float timeSinceHeld;

	public IntEntry lostFootageIndex;

	public BoolEntry boolEntry;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetFootage(out LostFootageDatabase.FootageRarityPair footage)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemLostDisc()
	{
		throw null;
	}
}
