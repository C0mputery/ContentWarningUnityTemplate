using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

public class Level : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Level _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CStart_003Ed__5(int _003C_003E1__state)
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

	public RichPresenceState richPresenceState;

	public Dictionary<PatrolPoint.PatrolGroup, List<PatrolPoint>> patrolGroups;

	public List<Light> lights;

	public static Level currentLevel;

	public bool levelIsReady;

	public Action OnLevelFinishedSetUp;

	public Action<bool, Vector3, float> toggleLights;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CStart_003Ed__5))]
	private IEnumerator Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupFinished()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatrolPoint GetClosestPoint(List<PatrolPoint.PatrolGroup> groups, Vector3 pos, PatrolPoint current, float maxHeightDif = 100000f, bool includeTemporary = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PatrolPoint> GetPointsInGroups(List<PatrolPoint.PatrolGroup> groups)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ToggleLights(bool setLightsOn, Vector3 position, float range)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleLightsForSeconds(bool setLightsOn, Vector3 position, float range, float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal PatrolPoint GetFreePointWithDistance(List<PatrolPoint.PatrolGroup> pgs, Vector3 position, int minDistance, float maxHeightDif, bool includeTemporary = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<PatrolPoint> GetPointsOutsideMinDistanceSortedOnClosest(List<PatrolPoint.PatrolGroup> pgs, Vector3 position, float minDistance, float maxHeightDif, bool includeTemporary = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal PatrolPoint GetClosestHiddenPoint(Vector3 vector3, bool includeTemporary = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddPoint(PatrolPoint patrolPoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RemovePoint(PatrolPoint patrolPoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal PatrolPoint GetRandomPoint(List<PatrolPoint.PatrolGroup> groups)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Level()
	{

	}
}
