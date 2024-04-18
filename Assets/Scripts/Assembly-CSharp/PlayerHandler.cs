using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
	public static PlayerHandler instance;

	public List<Player> players;

	public List<Player> playerAlive;

	public Action<Player> OnPlayerJoined;

	public Action<Player> OnPlayerLeft;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPlayer(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePlayer(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAnAlivePlayerSeePoint(Vector3 point, out Player firstPlayerThatCanSeeIt)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetPlayersClosestDistanceToAnotherPlayer(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetLargestClosestDistanceBetweenPlayers(out float maxMinDistanceBetweenPlayers, out Player mostAlonePlayer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Player GetClosestAlivePlayerToPoint(Vector3 point)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Player FindClosestPlayerToPlayer(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Player GetFurthestPlayerFromPlayer(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Player FindClosest(Vector3 point, List<Player> players)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Player GetNextPlayer(ref int currentPlayerCheckID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Player GetNextPlayerAlive(ref int currentPlayerCheckID, int offset = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Player GetNextPlayerAlive(Player currenPlayer = null, int offset = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetPlayerID(Player currenPlayer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetPlayerFromOwnerID(int photonViewOwnerActorNr, out Player o)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Player TryGetPlayerFromViewID(int viewID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Player> GetAlivePlayersWithinFlatDistanceFromPoint(Vector3 point, float distance)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal float PlayerVoiceVolumeAtPosition(Vector3 position, float minRange, float maxRange)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AllPlayersAsleep()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AllPlayersInBed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Player GetRandomPlayerAlive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerHandler()
	{

	}
}
