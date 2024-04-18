using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public abstract class PropertyGroupAttribute : Attribute
	{
		public string GroupID;

		public string GroupName;

		public float Order;

		public bool HideWhenChildrenAreInvisible;

		public string VisibleIf;

		public bool AnimateVisibility;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyGroupAttribute(string groupId, float order)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyGroupAttribute(string groupId)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyGroupAttribute Combine(PropertyGroupAttribute other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
