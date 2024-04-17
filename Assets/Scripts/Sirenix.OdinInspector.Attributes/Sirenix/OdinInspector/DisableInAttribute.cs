using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class DisableInAttribute : Attribute
	{
		public PrefabKind PrefabKind;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisableInAttribute(PrefabKind prefabKind)
		{
			throw null;
		}
	}
}
