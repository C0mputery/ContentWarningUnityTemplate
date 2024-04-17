using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class PreviewFieldAttribute : Attribute
	{
		private ObjectFieldAlignment alignment;

		private bool alignmentHasValue;

		private string previewGetter;

		public float Height;

		public FilterMode FilterMode;

		public ObjectFieldAlignment Alignment
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

		public bool AlignmentHasValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string PreviewGetter
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

		public bool PreviewGetterHasValue
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
		public PreviewFieldAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviewFieldAttribute(float height)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviewFieldAttribute(string previewGetter, FilterMode filterMode = FilterMode.Bilinear)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviewFieldAttribute(string previewGetter, float height, FilterMode filterMode = FilterMode.Bilinear)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviewFieldAttribute(float height, ObjectFieldAlignment alignment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviewFieldAttribute(string previewGetter, ObjectFieldAlignment alignment, FilterMode filterMode = FilterMode.Bilinear)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviewFieldAttribute(string previewGetter, float height, ObjectFieldAlignment alignment, FilterMode filterMode = FilterMode.Bilinear)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviewFieldAttribute(ObjectFieldAlignment alignment)
		{
			throw null;
		}
	}
}
