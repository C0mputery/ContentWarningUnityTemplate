using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class PropertyRangeAttribute : Attribute
	{
		public double Min;

		public double Max;

		public string MinGetter;

		public string MaxGetter;

		[Obsolete("Use the MinGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MinMember
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

		[Obsolete("Use the MaxGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MaxMember
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyRangeAttribute(double min, double max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyRangeAttribute(string minGetter, double max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyRangeAttribute(double min, string maxGetter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyRangeAttribute(string minGetter, string maxGetter)
		{
			throw null;
		}
	}
}
