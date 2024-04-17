using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class HorizontalGroupAttribute : PropertyGroupAttribute
	{
		private const int DefaultHorizontalGroupGap = 3;

		public float Width;

		public float MarginLeft;

		public float MarginRight;

		public float PaddingLeft;

		public float PaddingRight;

		public float MinWidth;

		public float MaxWidth;

		public float Gap;

		public string Title;

		public bool DisableAutomaticLabelWidth;

		public float LabelWidth;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HorizontalGroupAttribute(string group, float width = 0f, int marginLeft = 0, int marginRight = 0, float order = 0f) : base(group, order)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HorizontalGroupAttribute(float width = 0f, int marginLeft = 0, int marginRight = 0, float order = 0f) : this(null, width, marginLeft, marginRight, order)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
