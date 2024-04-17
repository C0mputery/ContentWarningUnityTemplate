using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class MaxValueAttribute : Attribute
	{
		public double MaxValue;

		public string Expression;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MaxValueAttribute(double maxValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MaxValueAttribute(string expression)
		{
			throw null;
		}
	}
}
