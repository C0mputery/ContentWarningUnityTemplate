using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public sealed class SuffixLabelAttribute : Attribute
	{
		public string Label;

		public bool Overlay;

		public string IconColor;

		private SdfIconType icon;

		public SdfIconType Icon
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

		public bool HasDefinedIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuffixLabelAttribute(string label, bool overlay = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuffixLabelAttribute(string label, SdfIconType icon, bool overlay = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuffixLabelAttribute(SdfIconType icon)
		{
			throw null;
		}
	}
}
