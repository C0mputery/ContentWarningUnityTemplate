using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class GradientAlphaKeyFormatter : MinimalBaseFormatter<GradientAlphaKey>
	{
		private static readonly Serializer<float> FloatSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref GradientAlphaKey value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref GradientAlphaKey value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GradientAlphaKeyFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GradientAlphaKeyFormatter()
		{
			throw null;
		}
	}
}
