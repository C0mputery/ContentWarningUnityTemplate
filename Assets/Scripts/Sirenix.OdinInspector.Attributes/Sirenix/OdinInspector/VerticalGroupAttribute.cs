using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class VerticalGroupAttribute : PropertyGroupAttribute
	{
		public float PaddingTop;

		public float PaddingBottom;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VerticalGroupAttribute(string groupId, float order = 0f) : base(groupId, order)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VerticalGroupAttribute(float order = 0f) : base(null, order)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
