using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Utilities
{
	public static class GUILayoutOptions
	{
		internal enum GUILayoutOptionType
		{
			Width = 0,
			Height = 1,
			MinWidth = 2,
			MaxHeight = 3,
			MaxWidth = 4,
			MinHeight = 5,
			ExpandHeight = 6,
			ExpandWidth = 7
		}

		public sealed class GUILayoutOptionsInstance : IEquatable<GUILayoutOptionsInstance>
		{
			private float value;

			internal GUILayoutOptionsInstance Parent;

			internal GUILayoutOptionType GUILayoutOptionType;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private GUILayoutOption[] GetCachedOptions()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static implicit operator GUILayoutOption[](GUILayoutOptionsInstance options)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private GUILayoutOption[] CreateOptionsArary()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private GUILayoutOptionsInstance Clone()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GUILayoutOptionsInstance()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance Width(float width)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance Height(float height)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance MaxHeight(float height)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance MaxWidth(float width)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance MinHeight(float height)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance MinWidth(float width)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance ExpandHeight(bool expand = true)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GUILayoutOptionsInstance ExpandWidth(bool expand = true)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void SetValue(GUILayoutOptionType type, float value)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void SetValue(GUILayoutOptionType type, bool value)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Equals(GUILayoutOptionsInstance other)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override int GetHashCode()
			{
				throw null;
			}
		}

		private static int CurrentCacheIndex;

		private static readonly GUILayoutOptionsInstance[] GUILayoutOptionsInstanceCache;

		private static readonly Dictionary<GUILayoutOptionsInstance, GUILayoutOption[]> GUILayoutOptionsCache;

		public static readonly GUILayoutOption[] EmptyGUIOptions;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GUILayoutOptions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance Width(float width)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance Height(float height)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance MaxHeight(float height)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance MaxWidth(float width)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance MinWidth(float width)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance MinHeight(float height)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance ExpandHeight(bool expand = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GUILayoutOptionsInstance ExpandWidth(bool expand = true)
		{
			throw null;
		}
	}
}
