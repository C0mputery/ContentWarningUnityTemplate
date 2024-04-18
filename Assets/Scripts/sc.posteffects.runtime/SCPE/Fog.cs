using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Environment/Fog")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Fog : VolumeComponent, IPostProcessComponent
	{
		[Serializable]
		public sealed class FogModeParameter : VolumeParameter<FogMode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FogModeParameter()
			{
				throw null;
			}
		}

		public enum FogColorSource
		{
			UniformColor = 0,
			GradientTexture = 1,
			SkyboxColor = 2
		}

		[Serializable]
		public sealed class FogColorSourceParameter : VolumeParameter<FogColorSource>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FogColorSourceParameter()
			{
				throw null;
			}
		}

		[Range(0f, 1f)]
		[Tooltip("Use the settings of the current active scene found under the Lighting tab\n\nThis is also advisable for third-party scripts that modify fog settings\n\nThis will force the effect to use the scene's fog color")]
		public BoolParameter useSceneSettings;

		[Tooltip("Sets how the fog distance is calculated")]
		public FogModeParameter fogMode;

		[Range(0f, 1f)]
		public ClampedFloatParameter globalDensity;

		public FloatParameter fogStartDistance;

		public FloatParameter fogEndDistance;

		[Space]
		[Tooltip("Color: use a uniform color for the fog\n\nGradient: sample a gradient texture to control the fog color over distance, the alpha channel controls the density\n\nSkybox: Sample the skybox's color for the fog, only works well with low detail skies")]
		public FogColorSourceParameter colorSource;

		[ColorUsage(true, true)]
		public ColorParameter fogColor;

		public TextureParameter fogColorGradient;

		[Tooltip("Automatic mode uses the current camera's far clipping plane to set the max distance\n\nOtherwise, a fixed value may be used instead")]
		public FloatParameter gradientDistance;

		public BoolParameter gradientUseFarClipPlane;

		[Header("Distance")]
		public BoolParameter distanceFog;

		[Min(0f)]
		public FloatParameter distanceDensity;

		[Tooltip("Distance based on radial distance from viewer, rather than parrallel")]
		public BoolParameter useRadialDistance;

		public Vector2Parameter horizonMinMax;

		[Range(0f, 1f)]
		[Tooltip("Determines how much the fog influences the skybox")]
		public ClampedFloatParameter skyboxInfluence;

		[Header("Directional Light")]
		[Tooltip("Translates the a Directional Light's direction and color into the fog. Creates a faux-atmospheric scattering effect.")]
		public BoolParameter enableDirectionalLight;

		[Tooltip("Use the intensity of the Directional Light that's set as the caster")]
		public BoolParameter useLightDirection;

		[Tooltip("Use the color of the Directional Light that's set as the caster")]
		public BoolParameter useLightColor;

		[Tooltip("Use the intensity of the Directional Light that's set as the caster")]
		public BoolParameter useLightIntensity;

		[ColorUsage(true, true)]
		public ColorParameter lightColor;

		public Vector3Parameter lightDirection;

		public FloatParameter lightIntensity;

		public ClampedFloatParameter lightExponent;

		[Header("Height")]
		[Tooltip("Enable vertical height fog")]
		public BoolParameter heightFog;

		[Tooltip("Height relative to 0 world height position")]
		public FloatParameter height;

		[Range(0.001f, 1f)]
		public FloatParameter heightDensity;

		[Header("Height noise (2D)")]
		[Tooltip("Enables height fog density variation through the use of a texture")]
		public BoolParameter heightFogNoise;

		[Tooltip("The density is read from this texture's red color channel")]
		public TextureParameter heightNoiseTex;

		[Range(0f, 1f)]
		public ClampedFloatParameter heightNoiseSize;

		[Range(0f, 1f)]
		public ClampedFloatParameter heightNoiseStrength;

		[Range(0f, 10f)]
		public ClampedFloatParameter heightNoiseSpeed;

		[Header("Light scattering")]
		[Tooltip("Execute a bloom pass to diffuse light in dense fog")]
		public BoolParameter lightScattering;

		[Space]
		[Min(0f)]
		public FloatParameter scatterIntensity;

		[Min(0f)]
		[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
		public FloatParameter scatterThreshold;

		[Range(1f, 10f)]
		public ClampedFloatParameter scatterDiffusion;

		[Range(0f, 1f)]
		[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
		public ClampedFloatParameter scatterSoftKnee;

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
		public Fog()
		{

		}
	}
}
