using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	[Obsolete("Use [HideIn(PrefabKind.PrefabAsset)] instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class HideInPrefabAssetsAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInPrefabAssetsAttribute()
		{
			throw null;
		}
	}
}
