using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Blurring/Blur")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Blur : VolumeComponent, IPostProcessComponent
	{
		public enum BlurMethod
		{
			Gaussian = 0,
			Box = 1
		}

		[Serializable]
		public sealed class BlurMethodParameter : VolumeParameter<BlurMethod>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public BlurMethodParameter()
			{
				throw null;
			}
		}

		[Tooltip("Box blurring uses fewer texture samples but has a limited blur range")]
		public BlurMethodParameter mode;

		[Tooltip("When enabled, the amount of blur passes is doubled")]
		public BoolParameter highQuality;

		public BoolParameter distanceFade;

		public FloatParameter startFadeDistance;

		public FloatParameter endFadeDistance;

		[Space]
		[Range(0f, 5f)]
		[Tooltip("The amount of blurring that must be performed")]
		public ClampedFloatParameter amount;

		[Range(1f, 12f)]
		[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
		public ClampedIntParameter iterations;

		[Range(1f, 4f)]
		[Tooltip("Every step halfs the resolution of the blur effect. Lower resolution provides a smoother blur but may induce flickering.")]
		public ClampedIntParameter downscaling;

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
		public Blur()
		{
			throw null;
		}
	}
}
