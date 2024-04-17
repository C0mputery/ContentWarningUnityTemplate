using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Events;

public class RPC_Relay : MonoBehaviour
{
	public UnityEvent event_Simple;

	private PhotonView view;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Call_Event_Simple()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_Event_Simple()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RPC_Relay()
	{
		throw null;
	}
}
