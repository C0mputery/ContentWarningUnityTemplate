using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class GradientFormatter : MinimalBaseFormatter<Gradient>
	{
		private static readonly Serializer<GradientAlphaKey[]> AlphaKeysSerializer;

		private static readonly Serializer<GradientColorKey[]> ColorKeysSerializer;

		private static readonly PropertyInfo ModeProperty;

		private static readonly Serializer<object> EnumSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Gradient GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Gradient value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Gradient value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GradientFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GradientFormatter()
		{
			throw null;
		}
	}
}
