using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class TypeInfoBoxAttribute : Attribute
	{
		public string Message;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeInfoBoxAttribute(string message)
		{

		}
	}
}
