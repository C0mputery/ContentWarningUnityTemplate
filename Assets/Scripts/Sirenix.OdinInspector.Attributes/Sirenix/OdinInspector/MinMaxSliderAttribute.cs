using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class MinMaxSliderAttribute : Attribute
	{
		public float MinValue;

		public float MaxValue;

		public string MinValueGetter;

		public string MaxValueGetter;

		public string MinMaxValueGetter;

		public bool ShowFields;

		[Obsolete("Use the MinValueGetter member instead.", false)]
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

		[Obsolete("Use the MaxValueGetter member instead.", false)]
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

		[Obsolete("Use the MinMaxValueGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MinMaxMember
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
		public MinMaxSliderAttribute(float minValue, float maxValue, bool showFields = false)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MinMaxSliderAttribute(string minValueGetter, float maxValue, bool showFields = false)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MinMaxSliderAttribute(float minValue, string maxValueGetter, bool showFields = false)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MinMaxSliderAttribute(string minValueGetter, string maxValueGetter, bool showFields = false)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MinMaxSliderAttribute(string minMaxValueGetter, bool showFields = false)
		{

		}
	}
}
