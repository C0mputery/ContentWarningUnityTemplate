using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class GUIColorAttribute : Attribute
	{
		public Color Color;

		public string GetColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GUIColorAttribute(float r, float g, float b, float a = 1f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GUIColorAttribute(string getColor)
		{
			throw null;
		}
	}
}
