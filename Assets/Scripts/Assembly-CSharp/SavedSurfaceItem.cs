using System;
using System.Runtime.CompilerServices;

[Serializable]
public class SavedSurfaceItem
{
	public string persistentID;

	public float posX;

	public float posY;

	public float posZ;

	public float rotX;

	public float rotY;

	public float rotZ;

	public float rotW;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Guid GetPersistentID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SavedSurfaceItem(PersistentObjectInfo persistentObject)
	{

	}
}
