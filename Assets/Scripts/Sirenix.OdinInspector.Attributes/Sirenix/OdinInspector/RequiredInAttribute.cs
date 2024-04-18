using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class RequiredInAttribute : Attribute
	{
		public string ErrorMessage;

		public PrefabKind PrefabKind;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInAttribute(PrefabKind kind)
		{

		}
	}
}
