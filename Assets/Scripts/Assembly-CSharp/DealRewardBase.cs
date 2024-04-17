using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public abstract class DealRewardBase
{
	[HideInInspector]
	public DIFFICULTY difficulty;

	[HideInInspector]
	public bool inited;

	public abstract bool UseInGame { get; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(DIFFICULTY difficulty)
	{
		throw null;
	}

	public abstract DealRewardBase CreateNew();

	public abstract string GetRewardDescription();

	public abstract bool ClaimReward();

	public abstract int GetIndex();

	public abstract string GetRewardClaimDescription();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DebugReward()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected int GetIndex<T>() where T : DealRewardBase
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected DealRewardBase()
	{
		throw null;
	}
}
