using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public class ButtonAttribute : ShowInInspectorAttribute
	{
		public string Name;

		public ButtonStyle Style;

		public bool Expanded;

		public bool DisplayParameters;

		public bool DirtyOnClick;

		public SdfIconType Icon;

		private int buttonHeight;

		private bool drawResult;

		private bool drawResultIsSet;

		private bool stretch;

		private IconAlignment buttonIconAlignment;

		private float buttonAlignment;

		public int ButtonHeight
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

		public IconAlignment IconAlignment
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

		public float ButtonAlignment
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

		public bool Stretch
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

		public bool DrawResult
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

		public bool DrawResultIsSet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool HasDefinedButtonHeight
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

		public bool HasDefinedIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool HasDefinedButtonIconAlignment
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

		public bool HasDefinedButtonAlignment
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

		public bool HasDefinedStretch
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
		public ButtonAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(ButtonSizes size)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(int buttonSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(string name, ButtonSizes buttonSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(string name, int buttonSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(ButtonStyle parameterBtnStyle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(int buttonSize, ButtonStyle parameterBtnStyle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(ButtonSizes size, ButtonStyle parameterBtnStyle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(string name, ButtonStyle parameterBtnStyle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(string name, int buttonSize, ButtonStyle parameterBtnStyle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(SdfIconType icon, IconAlignment iconAlignment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(SdfIconType icon)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonAttribute(SdfIconType icon, string name)
		{
			throw null;
		}
	}
}
