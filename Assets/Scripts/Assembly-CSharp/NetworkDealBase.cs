using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public abstract class NetworkDealBase
{
	public enum DEAL_STATE
	{
		uninited = 0,
		progressing = 1,
		failed = 2,
		success = 3
	}

	[Serializable]
	public class NetworkDealSerialized
	{
		public bool isValid;

		public int progress;

		public DEAL_STATE state;

		public int dealIndex;

		public int rewardIndex;

		public DIFFICULTY difficulty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NetworkDealBase UnSerialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NetworkDealSerialized()
		{
			throw null;
		}
	}

	[HideInInspector]
	public DIFFICULTY difficulty;

	private Sprite iconSprite;

	private int progress;

	[HideInInspector]
	public DealRewardBase reward;

	private DEAL_STATE state;

	public abstract List<DIFFICULTY> AllowedDifficulties { get; }

	public abstract string DealName { get; }

	public bool IsDirty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public abstract bool UseInGame { get; }

	public abstract RARITY Rarity { get; }

	public bool Inited
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsDone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsFailed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsSuccess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Progress
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

	public DEAL_STATE State
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

	public abstract string IconPath { get; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDirty()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearDirty()
	{
		throw null;
	}

	public abstract NetworkDealBase CreateNew();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(DealRewardBase reward, DIFFICULTY dif)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Sprite GetIcon()
	{
		throw null;
	}

	public abstract string DealDescription();

	public abstract void Update();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClaimReward()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetDifficultyText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkDealSerialized GetSerialized()
	{
		throw null;
	}

	public abstract int GetIndex();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected int GetIndex<T>()
	{
		throw null;
	}

	public abstract void OnDestroy();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReviewUploadContent(ContentBuffer contentBuffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAddedMoney(int money)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAddQuota(int quotaToAdd)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRemovedMoney(int removedAmount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected NetworkDealBase()
	{
		throw null;
	}
}
