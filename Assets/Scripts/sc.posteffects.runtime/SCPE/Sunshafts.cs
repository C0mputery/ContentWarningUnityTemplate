using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Environment/Sun Shafts")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Sunshafts //: VolumeComponent, IPostProcessComponent
	{
		public enum BlendMode
		{
			Additive = 0,
			Screen = 1
		}

		public enum SunShaftsResolution
		{
			Full = 1,
			Half = 2,
			Third = 3,
			Quarter = 4
		}

		[Serializable]
		public sealed class SunShaftsSourceParameter : VolumeParameter<BlendMode>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public SunShaftsSourceParameter()
//			{
//				throw null;
//			}
		}

		[Serializable]
		public sealed class SunShaftsResolutionParameter : VolumeParameter<SunShaftsResolution>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public SunShaftsResolutionParameter()
//			{
//				throw null;
//			}
		}

		[Tooltip("Use the color of the Directional Light that's set as the caster")]
		public BoolParameter useCasterColor;

		[Tooltip("Use the intensity of the Directional Light that's set as the caster")]
		public BoolParameter useCasterIntensity;

		[Tooltip("Additive mode adds the sunshaft color to the image, while Screen mode perserves color values")]
		public SunShaftsSourceParameter blendMode;

		[InspectorName("Resolution")]
		[Tooltip("Low, quater resolution\n\nNormal, half resolution\n\nHigh, full resolution\n\nLower resolutions may induce jittering")]
		public SunShaftsResolutionParameter resolution;

		[Tooltip("Enabling this option doubles the amount of blurring performed. Resulting in smoother sunshafts at a higher performance cost.")]
		public BoolParameter highQuality;

		[Tooltip("Any color values over this threshold will contribute to the sunshafts effect")]
		[InspectorName("Sky color threshold")]
		public ColorParameter sunThreshold;

		[InspectorName("Color")]
		public ColorParameter sunColor;

		[InspectorName("Intensity")]
		public FloatParameter sunShaftIntensity;

		[Range(0.1f, 1f)]
		[Tooltip("The degree to which the shafts’ brightness diminishes with distance from the caster")]
		public ClampedFloatParameter falloff;

		[Tooltip("The length of the sunrays from the caster's position to the camera")]
		[Min(0f)]
		public FloatParameter length;

		[Range(0f, 1f)]
		public FloatParameter noiseStrength;

		public static Vector3 sunPosition;

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
		public Sunshafts()
		{

		}
	}
}
