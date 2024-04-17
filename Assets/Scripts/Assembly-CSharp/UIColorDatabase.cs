using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(fileName = "UIColorDatabase", menuName = "UIColorDatabase")]
public class UIColorDatabase : SingletonAsset<UIColorDatabase>
{
	public Color WhiteColor;

	public Color BlackColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIColorDatabase()
	{
		throw null;
	}
}
