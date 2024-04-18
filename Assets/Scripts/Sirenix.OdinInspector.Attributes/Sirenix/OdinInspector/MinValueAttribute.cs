using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class MinValueAttribute : Attribute
	{
		public double MinValue;

		public string Expression;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MinValueAttribute(double minValue)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MinValueAttribute(string expression)
		{

		}
	}
}
