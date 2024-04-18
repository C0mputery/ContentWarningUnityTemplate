using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class SpookyMusicHandler : MonoBehaviour
{
	public int level;

	public static SpookyMusicHandler instance;

	private float sinceDanger;

	public float onVolume;

	private AudioSource source;

	private PhotonView view;

	private bool isDanger;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDanger(float dangerPercentage, int jumpScareLevel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToggleDanger(bool setDanger)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_ToggleDanger(bool setDanger)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpookyMusicHandler()
	{

	}
}
