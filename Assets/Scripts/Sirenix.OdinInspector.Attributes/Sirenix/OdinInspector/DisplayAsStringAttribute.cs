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

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(TextAlignment alignment)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, TextAlignment alignment)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize, TextAlignment alignment)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(TextAlignment alignment, bool enableRichText)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize, bool enableRichText)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, TextAlignment alignment, bool enableRichText)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize, bool enableRichText)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(int fontSize, TextAlignment alignment, bool enableRichText)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment, bool enableRichText)
		{

		}
	}
}
