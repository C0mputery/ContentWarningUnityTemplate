using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DefaultNamespace;
using UnityEngine;

public class RoundSpawner : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass12_0
	{
		public RoundSpawner _003C_003E4__this;

		public Transform spawn;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass12_1
	{
		public int i;
	}

	[CompilerGenerated]
	private sealed class _003CSpawnMonstersOutOfSight_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundSpawner _003C_003E4__this;

		public List<IBudgetCost> monsters;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass12_1 _003C_003E8__2;

		public float waitTime;

		private PatrolPoint _003Cp_003E5__2;

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
		public _003CSpawnMonstersOutOfSight_003Ed__12(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSpawnSecondRun_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public int budgetForSpawn;

		public int biggestPurchase;

		public RoundSpawner _003C_003E4__this;

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
		public _003CSpawnSecondRun_003Ed__7(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundSpawner _003C_003E4__this;

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

	public GameObject[] possibleSpawns;

	public int testBudget;

	public int testBiggestPurchase;

	public Vector2 testFirstWaveSize;

	public Vector2 testMinMaxSecondWaveWaitTime;

	private IBudgetCost[] spawnBudgetCosts;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CStart_003Ed__6))]
	private IEnumerator Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CSpawnSecondRun_003Ed__7))]
	private IEnumerator SpawnSecondRun(float waitTime, int budgetForSpawn, int biggestPurchase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnRound(int budget, int biggestPurchase, bool isFirstRound)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintMonstersPerDay(int day, int times)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrintRounds(int days = 51)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnMonsters(List<IBudgetCost> monsters)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CSpawnMonstersOutOfSight_003Ed__12))]
	private IEnumerator SpawnMonstersOutOfSight(List<IBudgetCost> monsters, float waitTime = 0.1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetPointDistanceWeigth(Vector3 point, Vector3 spawn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnMonster(IBudgetCost monster, PatrolPoint p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IBudgetCost GetMonster(ref int budget, int biggestPurchase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoundSpawner()
	{

	}
}
