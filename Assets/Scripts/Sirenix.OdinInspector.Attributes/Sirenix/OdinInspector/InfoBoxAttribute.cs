using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class InfoBoxAttribute : Attribute
	{
		public string Message;

		public InfoMessageType InfoMessageType;

		public string VisibleIf;

		public bool GUIAlwaysEnabled;

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
		public InfoBoxAttribute(string message, InfoMessageType infoMessageType = InfoMessageType.Info, string visibleIfMemberName = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoBoxAttribute(string message, string visibleIfMemberName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoBoxAttribute(string message, SdfIconType icon, string visibleIfMemberName = null)
		{
			throw null;
		}
	}
}
