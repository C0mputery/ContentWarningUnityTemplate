using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Rendering/Lens Flares")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class LensFlares : VolumeComponent, IPostProcessComponent
	{
		public BoolParameter debug;

		[Space]
		[Range(0f, 1f)]
		public ClampedFloatParameter intensity;

		[Range(0.01f, 5f)]
		[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
		public ClampedFloatParameter luminanceThreshold;

		[Header("Flares")]
		[Range(1f, 4f)]
		public ClampedIntParameter iterations;

		[Range(1f, 2f)]
		[Tooltip("Offsets the Flares towards the edge of the screen")]
		public ClampedFloatParameter distance;

		[Range(1f, 10f)]
		[Tooltip("Fades out the Flares towards the edge of the screen")]
		public ClampedFloatParameter falloff;

		[Header("Halo")]
		[Tooltip("Creates a halo at the center of the screen when looking directly at a bright spot")]
		[Range(0f, 1f)]
		public ClampedFloatParameter haloSize;

		[Range(0f, 100f)]
		public ClampedFloatParameter haloWidth;

		[Header("Colors and masking")]
		[Tooltip("Use a texture to mask out the effect")]
		public TextureParameter maskTex;

		[Range(0f, 20f)]
		[Tooltip("Refracts the color channels")]
		public ClampedFloatParameter chromaticAbberation;

		[Tooltip("Color the flares from the center of the screen to the outer edges")]
		public TextureParameter colorTex;

		[Header("Blur")]
		[Range(1f, 8f)]
		[Tooltip("The amount of blurring that must be performed")]
		public ClampedFloatParameter blur;

		[Range(1f, 12f)]
		[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
		public ClampedIntParameter passes;

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
		public LensFlares()
		{
			throw null;
		}
	}
}
