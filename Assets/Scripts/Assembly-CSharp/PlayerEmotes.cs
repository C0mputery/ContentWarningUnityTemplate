using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class PlayerEmotes : MonoBehaviour
{
	private Player player;

	private PhotonView photonView_g;

	public Item latestEmotePlayed;

	public bool IsPlayingEmote
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void StartEmote()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayEmote(Item emoteItem)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPC_PlayEmote(byte itemId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoEmote(Item emote)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoBookEquipEffect(int viewID, byte itemId, Vector3 pos, Quaternion rotation)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPC_DoBookEquipEffect(int viewID, byte itemId, Vector3 pos, Quaternion rotation)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerEmotes()
	{
		throw null;
	}
}
