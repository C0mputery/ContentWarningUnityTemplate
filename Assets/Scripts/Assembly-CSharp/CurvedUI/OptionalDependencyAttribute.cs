using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CurvedUI
{
	[Conditional("UNITY_CCU")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class OptionalDependencyAttribute : Attribute
	{
		public string dependentClass;

		public string define;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OptionalDependencyAttribute(string dependentClass, string define)
		{
			throw null;
		}
	}
}
