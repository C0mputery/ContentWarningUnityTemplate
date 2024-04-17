using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class InlineEditorAttribute : Attribute
	{
		private bool expanded;

		public bool DrawHeader;

		public bool DrawGUI;

		public bool DrawPreview;

		public float MaxHeight;

		public float PreviewWidth;

		public float PreviewHeight;

		public bool IncrementInlineEditorDrawerDepth;

		public InlineEditorObjectFieldModes ObjectFieldMode;

		public bool DisableGUIForVCSLockedAssets;

		public PreviewAlignment PreviewAlignment;

		public bool Expanded
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

		public bool ExpandedHasValue
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
		public InlineEditorAttribute(InlineEditorModes inlineEditorMode = InlineEditorModes.GUIOnly, InlineEditorObjectFieldModes objectFieldMode = InlineEditorObjectFieldModes.Boxed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InlineEditorAttribute(InlineEditorObjectFieldModes objectFieldMode)
		{
			throw null;
		}
	}
}
