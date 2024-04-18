using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class InlineButtonAttribute : Attribute
	{
		public string Action;

		public string Label;

		public string ShowIf;

		public string ButtonColor;

		public string TextColor;

		public SdfIconType Icon;

		public IconAlignment IconAlignment;

		[Obsolete("Use the Action member instead.", false)]
		public string MemberMethod
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
		public InlineButtonAttribute(string action, string label = null)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InlineButtonAttribute(string action, SdfIconType icon, string label = null)
		{

		}
	}
}
