using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PersistentObjectsHolder : RetrievableSingleton<PersistentObjectsHolder>
{
	private List<PersistentObjectInfo> m_PersistentDiveBellObjects;

	private List<PersistentObjectInfo> m_PersistentObjects;

	private List<PersistentObjectInfo> m_PersistentSurfaceObjects;

	private Dictionary<Pickup, PersistentObjectInfo> m_PersistentObjectDic;

	private string m_LastScene;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnPersistentSurfaceObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnPersistentDiveBellObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnPersistentObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnPersistentObjects(List<PersistentObjectInfo> objects)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindPersistantObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindPersistantSurfaceObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PersistentObjectInfo[] FindPersistantSurfaceObjectsLite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindDivebellItems()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddPersistentObject(PersistantObject go)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddPersistentObject(Pickup p, Item itemToUse)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddPersistentDiveBellObject(Pickup p, DivingBell bell)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPersistentObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPersistentSurfaceObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearPersistentDivebellObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetPersistantObjects()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PersistentObjectsHolder()
	{
		throw null;
	}
}
