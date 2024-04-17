using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class TableColumnWidthAttribute : Attribute
	{
		public int Width;

		public bool Resizable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TableColumnWidthAttribute(int width, bool resizable = true)
		{
			throw null;
		}
	}
}
