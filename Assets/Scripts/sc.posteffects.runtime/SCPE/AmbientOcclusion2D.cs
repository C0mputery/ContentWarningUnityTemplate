using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Rendering/AmbientOcclusion2D")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class AmbientOcclusion2D : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Shows only the effect, to alow for finetuning")]
		public BoolParameter aoOnly;

		[Header("Luminance-Based Amient Occlusion")]
		[Range(0f, 1f)]
		[Tooltip("Intensity")]
		public ClampedFloatParameter intensity;

		[Range(0.01f, 1f)]
		[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
		public ClampedFloatParameter luminanceThreshold;

		[Range(0f, 3f)]
		[Tooltip("Distance")]
		public ClampedFloatParameter distance;

		[Header("Blur")]
		[Range(0f, 3f)]
		[Tooltip("The amount of blurring that must be performed")]
		public ClampedFloatParameter blurAmount;

		[Range(1f, 8f)]
		[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
		public ClampedIntParameter iterations;

		[Range(1f, 4f)]
		[Tooltip("Every step halves the resolution of the blur effect. Lower resolution provides a smoother blur but may induce flickering.")]
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
		public AmbientOcclusion2D()
		{

		}
	}
}
