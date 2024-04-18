using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class IndentAttribute : Attribute
	{
		public int IndentLevel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndentAttribute(int indentLevel = 1)
		{

		}
	}
}
