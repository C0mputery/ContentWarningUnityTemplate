using System;
using System.Runtime.CompilerServices;

[Serializable]
public class Save
{
	public int SaveIndex;

	public string SaveID;

	public int CurrentDay;

	public int CurrentQuota;

	public int CurrentQuotaDay;

	public int Money;

	public NetworkDealBase.NetworkDealSerialized networkDeal;

	public SavedInventoryItem[] InventoryItems;

	public SavedSurfaceItem[] SurfaceItems;

	public bool Valid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public DateTime Date
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Guid GetSaveID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Save(int saveIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}
}
