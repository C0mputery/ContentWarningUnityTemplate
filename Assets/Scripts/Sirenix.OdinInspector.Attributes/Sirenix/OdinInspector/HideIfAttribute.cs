using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public sealed class HideIfAttribute : Attribute
	{
		public string Condition;

		public object Value;

		public bool Animate;

		[Obsolete("Use the Condition member instead.", false)]
		public string MemberName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideIfAttribute(string condition, bool animate = true)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideIfAttribute(string condition, object optionalValue, bool animate = true)
		{

		}
	}
}
