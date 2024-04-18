using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[IncludeMyAttributes]
	[ShowInInspector]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute
	{
		public ButtonSizes DefaultButtonSize;

		public bool UniformLayout;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResponsiveButtonGroupAttribute(string group = "_DefaultResponsiveButtonGroup") : base(group, 0f)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
