using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Blurring/Tilt Shift")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class TiltShift : VolumeComponent, IPostProcessComponent
	{
		public enum TiltShiftMethod
		{
			Horizontal = 0,
			Radial = 1
		}

		[Serializable]
		public sealed class TiltShifMethodParameter : VolumeParameter<TiltShiftMethod>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TiltShifMethodParameter()
			{
				throw null;
			}
		}

		public enum Quality
		{
			Performance = 0,
			Appearance = 1
		}

		[Serializable]
		public sealed class TiltShiftQualityParameter : VolumeParameter<Quality>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TiltShiftQualityParameter()
			{
				throw null;
			}
		}

		[Tooltip("The amount of blurring that must be performed")]
		public ClampedFloatParameter amount;

		public TiltShifMethodParameter mode;

		[Tooltip("Choose to use more texture samples, for a smoother blur when using a high blur amout")]
		public TiltShiftQualityParameter quality;

		public ClampedFloatParameter areaSize;

		public ClampedFloatParameter areaFalloff;

		public ClampedFloatParameter offset;

		public ClampedFloatParameter angle;

		public static bool debug;

		[SerializeField]
		public Shader shader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsTileCompatible()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SerializeShader()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TiltShift()
		{

		}
	}
}
