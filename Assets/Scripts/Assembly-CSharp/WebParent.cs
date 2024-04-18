using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class WebParent : MonoBehaviour
{
	public int webs;

	public GameObject webObj;

	private PhotonView view;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Spawns()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_SynkNets(Vector3[] positions, Vector3[] p1, Vector3[] p2, Quaternion[] rots)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RequestStick(Player player, Web web, int bodypartID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCM_RequestStick(int playerID, int webID, int bodypartID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_Stick(int playerID, int webID, int bodypartID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void LetPlayerGo(Web web)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_LetPlayerGo(int webID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WebParent()
	{

	}
}
