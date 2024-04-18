using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Attack_Spider : MonoBehaviour
{
	public GameObject projectile;

	private Bot bot;

	private Player player;

	private PhotonView view;

	private MonsterAnimationHandler anim;

	private MonsterAnimationValues values;

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
	private void RPCA_ThrowNet()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Attack_Spider()
	{

	}
}
