using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public class ChildGameObjectsOnlyAttribute : Attribute
	{
		public bool IncludeSelf;

		public bool IncludeInactive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChildGameObjectsOnlyAttribute()
		{

		}
	}
}
