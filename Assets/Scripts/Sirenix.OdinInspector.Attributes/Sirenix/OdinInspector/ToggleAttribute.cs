using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ToggleAttribute : Attribute
	{
		public string ToggleMemberName;

		public bool CollapseOthersOnExpand;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ToggleAttribute(string toggleMemberName)
		{

		}
	}
}
