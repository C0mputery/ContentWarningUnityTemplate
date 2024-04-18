using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Attacks_Bombs : MonoBehaviour
{
	public GameObject explosion;

	public GameObject fuzeObj;

	public Item itemToSpawn;

	private Bot bot;

	private Player player;

	private PhotonView view;

	private MonsterAnimationHandler anim;

	private MonsterAnimationValues values;

	public float throwForce;

	private bool hasLit;

	public float secondsToExplode;

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
	private void RPCA_BombFuzeAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_BombThrowAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Attacks_Bombs()
	{

	}
}
