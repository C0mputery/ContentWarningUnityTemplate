using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LimitlessDev.RetroLookPro
{
	[Serializable]
	public class ColorPalettePreset : ScriptableObject
	{
		public effectPreset preset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorPalettePreset()
		{

		}
	}
}
