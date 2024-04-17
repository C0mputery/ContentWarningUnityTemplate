using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use [HideIn(PrefabKind.PrefabInstance)] instead.", false)]
	public class HideInPrefabInstancesAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInPrefabInstancesAttribute()
		{
			throw null;
		}
	}
}
