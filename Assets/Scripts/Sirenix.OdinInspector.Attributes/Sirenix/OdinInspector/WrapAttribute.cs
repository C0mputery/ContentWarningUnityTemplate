using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class WrapAttribute : Attribute
	{
		public double Min;

		public double Max;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapAttribute(double min, double max)
		{

		}
	}
}
