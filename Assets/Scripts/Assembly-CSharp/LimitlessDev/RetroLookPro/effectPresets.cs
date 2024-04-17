using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LimitlessDev.RetroLookPro
{
	[Serializable]
	public class effectPresets : ScriptableObject
	{
		public List<ColorPalettePreset> presetsList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public effectPresets()
		{
			throw null;
		}
	}
}
