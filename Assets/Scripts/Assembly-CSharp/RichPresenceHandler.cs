using System.Runtime.CompilerServices;
using Discord;

public static class RichPresenceHandler
{
	private static global::Discord.Discord _discord;

	private static RichPresenceState _currentState;

	private static int _currentDay;

	private static string _currentViews;

	private static string _currentQuota;

	private static string _currentGroup;

	private static int _currentPlayersInGroup;

	private static int _currentMaxPlayersInGroup;

	private static bool m_isDiscordDirty;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPresenceState(RichPresenceState state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetGroup(string group)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetGroupSize(int playersInServer, int maxSize)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Clear()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetRoomsStats(string views, string quota, int currentDay)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DirtyDiscord()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void UpdateDiscord()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetDetailsString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetStateString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Initialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deinitialize()
	{
		throw null;
	}
}
