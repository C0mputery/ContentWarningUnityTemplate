using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Rendering/Light Streaks")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class LightStreaks //: VolumeComponent, IPostProcessComponent
	{
		public enum Quality
		{
			Performance = 0,
			Appearance = 1
		}

		[Serializable]
		public sealed class BlurMethodParameter : VolumeParameter<Quality>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public BlurMethodParameter()
//			{
//				throw null;
//			}
		}

		[Tooltip("Choose between Box and Gaussian blurring methods.\n\nBox blurring is more efficient but has a limited blur range")]
		public BlurMethodParameter quality;

		[Range(0f, 1f)]
		[Tooltip("Shows only the effect, to allow for finetuning")]
		public BoolParameter debug;

		[Header("Anamorphic Lensfares")]
		[Range(0f, 1f)]
		[Tooltip("Intensity")]
		public ClampedFloatParameter intensity;

		[Range(0.01f, 5f)]
		[Tooltip("Luminance threshold, pixels above this threshold (material's emission value) will contribute to the effect")]
		public ClampedFloatParameter luminanceThreshold;

		[Range(-1f, 1f)]
		[Tooltip("Negative values become horizontal whereas postive values are vertical")]
		public ClampedFloatParameter direction;

		[Header("Blur")]
		[Range(0f, 10f)]
		[Tooltip("The amount of blurring that must be performed")]
		public ClampedFloatParameter blur;

		[Range(1f, 8f)]
		[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
		public ClampedIntParameter iterations;

		[Range(1f, 4f)]
		[Tooltip("Every step halfs the resolution of the blur effect. Lower resolution provides a smoother blur but may induce flickering")]
		public ClampedIntParameter downscaling;

		[SerializeField]
		public Shader shader;

//		[MethodImpl(MethodImplOptions.NoInlining)]
//		public bool IsActive()
//		{
//			throw null;
//		}

//		[MethodImpl(MethodImplOptions.NoInlining)]
//		public bool IsTileCompatible()
//		{
//			throw null;
//		}

//		[MethodImpl(MethodImplOptions.NoInlining)]
//		private void Reset()
//		{
//			throw null;
//		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SerializeShader()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LightStreaks()
		{

		}
	}
}
