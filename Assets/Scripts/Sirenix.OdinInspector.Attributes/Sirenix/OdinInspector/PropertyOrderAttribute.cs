using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class PropertyOrderAttribute : Attribute
	{
		public float Order;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyOrderAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyOrderAttribute(float order)
		{

		}
	}
}
