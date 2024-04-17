using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class AnimationCurveFormatter : MinimalBaseFormatter<AnimationCurve>
	{
		private static readonly Serializer<Keyframe[]> KeyframeSerializer;

		private static readonly Serializer<WrapMode> WrapModeSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override AnimationCurve GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref AnimationCurve value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref AnimationCurve value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationCurveFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AnimationCurveFormatter()
		{
			throw null;
		}
	}
}
