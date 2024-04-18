using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class WeakColorBlockFormatter : WeakBaseFormatter
	{
		private static readonly Serializer<float> FloatSerializer;

		private static readonly Serializer<Color> ColorSerializer;

		private readonly PropertyInfo normalColor;

		private readonly PropertyInfo highlightedColor;

		private readonly PropertyInfo pressedColor;

		private readonly PropertyInfo disabledColor;

		private readonly PropertyInfo colorMultiplier;

		private readonly PropertyInfo fadeDuration;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakColorBlockFormatter(Type colorBlockType) : base(null)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref object value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WeakColorBlockFormatter()
		{
			throw null;
		}
	}
}
