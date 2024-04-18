using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Image/Color Grading LUT")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class LUT : VolumeComponent, IPostProcessComponent
	{
		public enum Mode
		{
			Single = 0,
			DistanceBased = 1
		}

		[Serializable]
		public sealed class ModeParam : VolumeParameter<Mode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ModeParam()
			{
				throw null;
			}
		}

		[Tooltip("Distance-based mode blends two LUTs over a distance")]
		public ModeParam mode;

		public FloatParameter startFadeDistance;

		public FloatParameter endFadeDistance;

		[Range(0f, 1f)]
		[Tooltip("Fades the effect in or out")]
		public ClampedFloatParameter intensity;

		[Tooltip("Supply a LUT strip texture.")]
		public TextureParameter lutNear;

		public TextureParameter lutFar;

		[Range(0f, 1f)]
		public ClampedFloatParameter invert;

		[Range(0f, 1f)]
		[Tooltip("Increases the saturation of muted colors")]
		public ClampedFloatParameter vibrance;

		[ColorUsage(false, false)]
		[Tooltip("Controls the effect of vibrancy for each color channel (RGB)")]
		public ColorParameter vibranceRGBBalance;

		public static bool Bypass;

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
		public LUT()
		{

		}
	}
}
