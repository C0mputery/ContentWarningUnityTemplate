using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using Steamworks;
using UnityEngine;

public class SteamAvatarHandler : RetrievableSingleton<SteamAvatarHandler>
{
	private HashSet<ulong> m_currentlyRequestedAvatars;

	private Callback<PersonaStateChange_t> m_PersonaStateChange;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPersonaStateChange(PersonaStateChange_t param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasAvatarForPlayer(Photon.Realtime.Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetSteamIDForPlayer(Photon.Realtime.Player player, out CSteamID steamID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetAvatarForPlayer(Photon.Realtime.Player player, out Sprite icon)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool RequestSteamAvatar(CSteamID steamID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SteamAvatarHandler()
	{

	}
}
