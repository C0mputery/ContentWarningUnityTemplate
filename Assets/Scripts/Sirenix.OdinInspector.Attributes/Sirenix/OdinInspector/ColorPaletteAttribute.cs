using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ColorPaletteAttribute : Attribute
	{
		public string PaletteName;

		public bool ShowAlpha;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorPaletteAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorPaletteAttribute(string paletteName)
		{

		}
	}
}
