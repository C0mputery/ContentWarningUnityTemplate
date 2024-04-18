using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class HideNetworkBehaviourFieldsAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideNetworkBehaviourFieldsAttribute()
		{

		}
	}
}
