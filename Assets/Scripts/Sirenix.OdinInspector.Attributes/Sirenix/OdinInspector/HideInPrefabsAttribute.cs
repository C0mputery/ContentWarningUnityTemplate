using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Obsolete("Use [HideIn(PrefabKind.PrefabAsset | PrefabKind.PrefabInstance)] instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class HideInPrefabsAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInPrefabsAttribute()
		{

		}
	}
}
