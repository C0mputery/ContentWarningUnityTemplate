using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class TitleAttribute : Attribute
	{
		public string Title;

		public string Subtitle;

		public bool Bold;

		public bool HorizontalLine;

		public TitleAlignments TitleAlignment;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleAttribute(string title, string subtitle = null, TitleAlignments titleAlignment = TitleAlignments.Left, bool horizontalLine = true, bool bold = true)
		{

		}
	}
}
