using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LimitlessDev.RetroLookPro
{
	[Serializable]
	public class effectPreset
	{
		public string effectName;

		public int numberOfColors;

		public Color32[] palette;

		public bool changed;

		public Color32[] pixels;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public effectPreset()
		{
			throw null;
		}
	}
}
