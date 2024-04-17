using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class LabelTextAttribute : Attribute
	{
		public string Text;

		public bool NicifyText;

		public SdfIconType Icon;

		public string IconColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LabelTextAttribute(string text)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LabelTextAttribute(SdfIconType icon)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LabelTextAttribute(string text, bool nicifyText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LabelTextAttribute(string text, SdfIconType icon)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LabelTextAttribute(string text, bool nicifyText, SdfIconType icon)
		{
			throw null;
		}
	}
}
