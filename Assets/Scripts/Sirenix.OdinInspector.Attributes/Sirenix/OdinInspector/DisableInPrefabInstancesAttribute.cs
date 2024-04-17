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
	[Obsolete("Use [DisableIn(PrefabKind.PrefabInstance)] instead.", false)]
	public class DisableInPrefabInstancesAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisableInPrefabInstancesAttribute()
		{
			throw null;
		}
	}
}
