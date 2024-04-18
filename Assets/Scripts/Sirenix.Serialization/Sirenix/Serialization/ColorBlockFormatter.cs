using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class ColorBlockFormatter<T> : MinimalBaseFormatter<T>
	{
		private static readonly Serializer<float> FloatSerializer;

		private static readonly Serializer<Color> ColorSerializer;

		private static readonly PropertyInfo normalColor;

		private static readonly PropertyInfo highlightedColor;

		private static readonly PropertyInfo pressedColor;

		private static readonly PropertyInfo disabledColor;

		private static readonly PropertyInfo colorMultiplier;

		private static readonly PropertyInfo fadeDuration;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref T value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorBlockFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ColorBlockFormatter()
		{
			throw null;
		}
	}
}
