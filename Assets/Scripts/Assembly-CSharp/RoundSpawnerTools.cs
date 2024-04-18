using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoundSpawnerTools : MonoBehaviour
{
	public class ToolWithWeight
	{
		public Item tool;

		public float weight;

		public int BudgetCost
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float Rarity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ToolWithWeight()
		{
			throw null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundSpawnerTools _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CStart_003Ed__6(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public static RoundSpawnerTools me;

	public int testDay;

	public GameObject artifactSpawnerPrefab;

	public List<Item> possibleSpawns;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Populate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CStart_003Ed__6))]
	private IEnumerator Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnRound(int budget, float rarestPurchase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintToolsPerDay(int day, int times)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Item> GetToolsToSpawn(int budget, float rarestPurchase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateArtifactSpawners(List<Item> artifacts)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 GetRandPointWithWeight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Item GetArtifact(ref int budget, List<Item> possibleSpawns, float rarestPurchase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item GetRandomArtifactByRarity(Item[] possibleSpawns)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoundSpawnerTools()
	{

	}
}
