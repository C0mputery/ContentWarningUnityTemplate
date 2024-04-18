using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ToggleGroupAttribute : PropertyGroupAttribute
	{
		public string ToggleGroupTitle;

		public bool CollapseOthersOnExpand;

		public string ToggleMemberName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[Obsolete("Add a $ infront of group title instead, i.e: \"$MyStringMember\".")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string TitleStringMemberName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ToggleGroupAttribute(string toggleMemberName, float order = 0f, string groupTitle = null) : base(toggleMemberName, order)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ToggleGroupAttribute(string toggleMemberName, string groupTitle) : base(toggleMemberName)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use [ToggleGroup(\"toggleMemberName\", groupTitle: \"$titleStringMemberName\")] instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ToggleGroupAttribute(string toggleMemberName, float order, string groupTitle, string titleStringMemberName) : base(toggleMemberName, order)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
