using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class DisplayAsStringAttribute : Attribute
	{
		public bool Overflow;

		public TextAlignment Alignment;

		public int FontSize;

		public bool EnableRichText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(TextAlignment alignment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, TextAlignment alignment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize, TextAlignment alignment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(TextAlignment alignment, bool enableRichText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize, bool enableRichText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, TextAlignment alignment, bool enableRichText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize, bool enableRichText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize, TextAlignment alignment, bool enableRichText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment, bool enableRichText)
		{
			throw null;
		}
	}
}
