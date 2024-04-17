using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Attack_Shove : MonoBehaviour
{
	private Player player;

	private Bot bot;

	private PhotonView view;

	public MonsterAnimationValues val;

	public SFX_Instance punchSFX;

	private bool punch;

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
	private void Collide(Collision col, Bodypart part)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_Hit(int viewID, int bodyPartID, Vector3 force)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Attack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_Punch()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Attack_Shove()
	{
		throw null;
	}
}
