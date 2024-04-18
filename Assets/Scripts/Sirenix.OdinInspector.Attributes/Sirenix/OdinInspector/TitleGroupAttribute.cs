using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class TitleGroupAttribute : PropertyGroupAttribute
	{
		public string Subtitle;

		public TitleAlignments Alignment;

		public bool HorizontalLine;

		public bool BoldTitle;

		public bool Indent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleGroupAttribute(string title, string subtitle = null, TitleAlignments alignment = TitleAlignments.Left, bool horizontalLine = true, bool boldTitle = true, bool indent = false, float order = 0f) : base(title, order)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
