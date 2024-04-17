using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class KeyframeFormatter : MinimalBaseFormatter<Keyframe>
	{
		private static readonly Serializer<float> FloatSerializer;

		private static readonly Serializer<int> IntSerializer;

		private static readonly bool Is_In_2018_1_Or_Above;

		private static IFormatter<Keyframe> Formatter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KeyframeFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Keyframe value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Keyframe value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyframeFormatter()
		{
			throw null;
		}
	}
}
