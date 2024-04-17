using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class MultiLinePropertyAttribute : Attribute
	{
		public int Lines;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiLinePropertyAttribute(int lines = 3)
		{
			throw null;
		}
	}
}
