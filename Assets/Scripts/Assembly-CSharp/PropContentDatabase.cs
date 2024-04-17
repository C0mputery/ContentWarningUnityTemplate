using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(menuName = "Database/PropEventDatabase", order = 9999, fileName = "PropContentDatabase")]
public class PropContentDatabase : ObjectDatabaseAsset<PropContentDatabase, PropContent>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PropContent GetEntryFromID(ushort id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropContentDatabase()
	{
		throw null;
	}
}
