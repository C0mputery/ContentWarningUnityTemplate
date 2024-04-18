using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class WalkieTalkie : ItemInstanceBehaviour
{
	private static List<WalkieTalkiePlayer> m_PlayersWithWalkieTalkies;

	private OnOffEntry m_onOffEntry;

	public BatteryDisplay m_batteryDisplay;

	private PhotonView m_Owner;

	private AudioSource m_RemoteSpeaker;

	private PlayerVoiceHandler _mHandler;

	private static bool m_LocalWalkieOn;

	private bool m_PlayingStatic;

	public SFX_Instance sfxOn;

	public SFX_Instance sfxOff;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendRemoteWalkieTalkieVoice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayStaticOnTalkies()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopStaticOnTalkies()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartSendingWalkieTalkieVoice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopSendingWalkieTalkieVoice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddOwnerToTalkieList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveOwnerFromTalkieList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkieTalkie()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WalkieTalkie()
	{
		throw null;
	}
}
