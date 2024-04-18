using System.Runtime.CompilerServices;
using DefaultNamespace;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Serialization;

public class Bot_Angler : MonoBehaviour
{
	public Bot bot;

	public Bot_AnglerMimic mimic;

	public float aggroRange;

	public float defaultMimicDistance;

	public Collider suckCollider;

	public ParticleSystem suckPart;

	public Animator suckAnim;

	private Antenna antenna;

	public float suckingRange;

	public Player mimicingPlayer;

	private bool isSucking;

	private PhotonView m_PhotonView;

	public VoiceRemoteMimic m_RemoteMimic;

	[FormerlySerializedAs("suchPoint")]
	public Transform suckPoint;

	public float minDistanceForPlayerToBeConsideredToBeAlone;

	public float aggroRangeIfSeperated;

	public bool IsSucking
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
	public float GetMinDistanceToOtherPlayers(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SomeoneIsAlone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindAndSetPlayerToMimic()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_Suck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_StopSuck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnMimic()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindMimic()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_RemoveMimic()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPC_Mimic(int targetViewID, int mimicViewID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_Angler()
	{

	}
}
