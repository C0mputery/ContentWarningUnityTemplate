using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class BoxGroupAttribute : PropertyGroupAttribute
	{
		public bool ShowLabel;

		public bool CenterLabel;

		public string LabelText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BoxGroupAttribute(string group, bool showLabel = true, bool centerLabel = false, float order = 0f) : base(group, order)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BoxGroupAttribute() : base(null, 69f)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
