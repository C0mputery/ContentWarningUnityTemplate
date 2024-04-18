using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class GradientColorKeyFormatter : MinimalBaseFormatter<GradientColorKey>
	{
		private static readonly Serializer<Color> ColorSerializer;

		private static readonly Serializer<float> FloatSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref GradientColorKey value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref GradientColorKey value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GradientColorKeyFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GradientColorKeyFormatter()
		{
			throw null;
		}
	}
}
