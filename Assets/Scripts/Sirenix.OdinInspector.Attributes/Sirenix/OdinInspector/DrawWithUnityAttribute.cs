using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class DrawWithUnityAttribute : Attribute
	{
		public bool PreferImGUI;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DrawWithUnityAttribute()
		{

		}
	}
}
