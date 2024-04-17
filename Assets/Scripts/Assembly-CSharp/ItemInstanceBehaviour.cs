using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class ItemInstanceBehaviour : MonoBehaviour
{
	[FormerlySerializedAs("isLocal")]
	public bool isHeldByMe;

	[FormerlySerializedAs("isMine")]
	public bool isSimulatedByMe;

	public ItemInstance itemInstance;

	[FormerlySerializedAs("inSomonesHand")]
	public bool isHeld;

	public abstract void ConfigItem(ItemInstanceData data, PhotonView playerView);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ItemInstanceBehaviour()
	{
		throw null;
	}
}
