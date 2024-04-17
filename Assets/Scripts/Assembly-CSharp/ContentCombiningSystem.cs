using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(menuName = "Database/ContentCombiningSystem", order = 9999, fileName = "ContentCombiningSystem")]
public class ContentCombiningSystem : ObjectDatabaseAsset<ContentCombiningSystem, ContentCombiner>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ContentEventFrame> CombineEvents(List<ContentEventFrame> events)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContentCombiningSystem()
	{
		throw null;
	}
}
