using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class HideInAttribute : Attribute
	{
		public PrefabKind PrefabKind;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInAttribute(PrefabKind prefabKind)
		{

		}
	}
}
