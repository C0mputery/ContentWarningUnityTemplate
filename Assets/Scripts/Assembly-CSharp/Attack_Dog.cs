using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Attack_Dog : MonoBehaviour
{
	public Light light;

	public Transform beam;

	private Player player;

	private Bot bot;

	private Bodypart hip;

	private Bodypart neck;

	private Bodypart head;

	public GameObject projectile;

	public float fireRate;

	public float spread;

	public Transform firePos;

	private PhotonView view;

	private float counter;

	private float aimLevel;

	public SFX_Instance targetSfx;

	private bool t;

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
	private void HandleLight()
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
	public void RPCA_DogFire(Vector3 pos, Vector3 dir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AimAtTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Attack_Dog()
	{

	}
}
