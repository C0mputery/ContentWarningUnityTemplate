using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace HorizonBasedAmbientOcclusion.Universal
{
	[ExecuteInEditMode]
	[VolumeComponentMenu("Lighting/HBAO")]
	public class HBAO : VolumeComponent, IPostProcessComponent
	{
		public enum Preset
		{
			FastestPerformance = 0,
			FastPerformance = 1,
			Normal = 2,
			HighQuality = 3,
			HighestQuality = 4,
			Custom = 5
		}

		public enum Mode
		{
			Normal = 0,
			LitAO = 1
		}

		public enum RenderingPath
		{
			Forward = 0,
			Deferred = 1
		}

		public enum Quality
		{
			Lowest = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			Highest = 4
		}

		public enum Resolution
		{
			Full = 0,
			Half = 1
		}

		public enum NoiseType
		{
			Dither = 0,
			InterleavedGradientNoise = 1,
			SpatialDistribution = 2
		}

		public enum Deinterleaving
		{
			Disabled = 0,
			x4 = 1
		}

		public enum DebugMode
		{
			Disabled = 0,
			AOOnly = 1,
			ColorBleedingOnly = 2,
			SplitWithoutAOAndWithAO = 3,
			SplitWithAOAndAOOnly = 4,
			SplitWithoutAOAndAOOnly = 5,
			ViewNormals = 6
		}

		public enum BlurType
		{
			None = 0,
			Narrow = 1,
			Medium = 2,
			Wide = 3,
			ExtraWide = 4
		}

		public enum PerPixelNormals
		{
			Reconstruct2Samples = 0,
			Reconstruct4Samples = 1,
			Camera = 2
		}

		public enum VarianceClipping
		{
			Disabled = 0,
			_4Tap = 1,
			_8Tap = 2
		}

		[Serializable]
		public sealed class PresetParameter : VolumeParameter<Preset>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public PresetParameter(Preset value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class ModeParameter : VolumeParameter<Mode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ModeParameter(Mode value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class RenderingPathParameter : VolumeParameter<RenderingPath>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public RenderingPathParameter(RenderingPath value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class QualityParameter : VolumeParameter<Quality>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public QualityParameter(Quality value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class DeinterleavingParameter : VolumeParameter<Deinterleaving>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public DeinterleavingParameter(Deinterleaving value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class ResolutionParameter : VolumeParameter<Resolution>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResolutionParameter(Resolution value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class NoiseTypeParameter : VolumeParameter<NoiseType>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public NoiseTypeParameter(NoiseType value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class DebugModeParameter : VolumeParameter<DebugMode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public DebugModeParameter(DebugMode value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class PerPixelNormalsParameter : VolumeParameter<PerPixelNormals>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public PerPixelNormalsParameter(PerPixelNormals value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class VarianceClippingParameter : VolumeParameter<VarianceClipping>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public VarianceClippingParameter(VarianceClipping value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class BlurTypeParameter : VolumeParameter<BlurType>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public BlurTypeParameter(BlurType value, bool overrideState = false)
			{
				throw null;
			}
		}

		[Serializable]
		public sealed class MinMaxFloatParameter : VolumeParameter<Vector2>
		{
			public float min;

			public float max;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MinMaxFloatParameter(Vector2 value, float min, float max, bool overrideState = false)
			{
				throw null;
			}
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			public bool isExpanded;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SettingsGroup()
			{
				throw null;
			}
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class ParameterDisplayName : Attribute
		{
			public string name;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ParameterDisplayName(string name)
			{
				throw null;
			}
		}

		public class Presets : SettingsGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Presets()
			{
				throw null;
			}
		}

		public class GeneralSettings : SettingsGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GeneralSettings()
			{
				throw null;
			}
		}

		public class AOSettings : SettingsGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AOSettings()
			{
				throw null;
			}
		}

		public class TemporalFilterSettings : SettingsGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemporalFilterSettings()
			{
				throw null;
			}
		}

		public class BlurSettings : SettingsGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public BlurSettings()
			{
				throw null;
			}
		}

		public class ColorBleedingSettings : SettingsGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ColorBleedingSettings()
			{
				throw null;
			}
		}

		[Presets]
		public PresetParameter preset;

		[Tooltip("The mode of the AO.")]
		[GeneralSettings]
		[Space(6f)]
		public ModeParameter mode;

		[Tooltip("The rendering path used for AO. Temporary settings as for now rendering path is internal to renderer settings.")]
		[GeneralSettings]
		[Space(6f)]
		public RenderingPathParameter renderingPath;

		[Tooltip("The quality of the AO.")]
		[GeneralSettings]
		[Space(6f)]
		public QualityParameter quality;

		[Tooltip("The deinterleaving factor.")]
		[GeneralSettings]
		public DeinterleavingParameter deinterleaving;

		[Tooltip("The resolution at which the AO is calculated.")]
		[GeneralSettings]
		public ResolutionParameter resolution;

		[Tooltip("The type of noise to use.")]
		[GeneralSettings]
		[Space(10f)]
		public NoiseTypeParameter noiseType;

		[Tooltip("The debug mode actually displayed on screen.")]
		[GeneralSettings]
		[Space(10f)]
		public DebugModeParameter debugMode;

		[Tooltip("AO radius: this is the distance outside which occluders are ignored.")]
		[AOSettings]
		[Space(6f)]
		public ClampedFloatParameter radius;

		[Tooltip("Maximum radius in pixels: this prevents the radius to grow too much with close-up object and impact on performances.")]
		[AOSettings]
		public ClampedFloatParameter maxRadiusPixels;

		[Tooltip("For low-tessellated geometry, occlusion variations tend to appear at creases and ridges, which betray the underlying tessellation. To remove these artifacts, we use an angle bias parameter which restricts the hemisphere.")]
		[AOSettings]
		public ClampedFloatParameter bias;

		[Tooltip("This value allows to scale up the ambient occlusion values.")]
		[AOSettings]
		public ClampedFloatParameter intensity;

		[Tooltip("Enable/disable MultiBounce approximation.")]
		[AOSettings]
		public BoolParameter useMultiBounce;

		[Tooltip("MultiBounce approximation influence.")]
		[AOSettings]
		public ClampedFloatParameter multiBounceInfluence;

		[Tooltip("How much AO affect direct lighting.")]
		[AOSettings]
		public ClampedFloatParameter directLightingStrength;

		[Tooltip("The amount of AO offscreen samples are contributing.")]
		[AOSettings]
		public ClampedFloatParameter offscreenSamplesContribution;

		[Tooltip("The max distance to display AO.")]
		[AOSettings]
		[Space(10f)]
		public FloatParameter maxDistance;

		[Tooltip("The distance before max distance at which AO start to decrease.")]
		[AOSettings]
		public FloatParameter distanceFalloff;

		[Tooltip("The type of per pixel normals to use.")]
		[AOSettings]
		[Space(10f)]
		public PerPixelNormalsParameter perPixelNormals;

		[Tooltip("This setting allow you to set the base color if the AO, the alpha channel value is unused.")]
		[AOSettings]
		[Space(10f)]
		public ColorParameter baseColor;

		[TemporalFilterSettings]
		[ParameterDisplayName("Enabled")]
		[Space(6f)]
		public BoolParameter temporalFilterEnabled;

		[Tooltip("The type of variance clipping to use.")]
		[TemporalFilterSettings]
		public VarianceClippingParameter varianceClipping;

		[Tooltip("The type of blur to use.")]
		[BlurSettings]
		[ParameterDisplayName("Type")]
		[Space(6f)]
		public BlurTypeParameter blurType;

		[Tooltip("This parameter controls the depth-dependent weight of the bilateral filter, to avoid bleeding across edges. A zero sharpness is a pure Gaussian blur. Increasing the blur sharpness removes bleeding by using lower weights for samples with large depth delta from the current pixel.")]
		[BlurSettings]
		[Space(10f)]
		public ClampedFloatParameter sharpness;

		[ColorBleedingSettings]
		[ParameterDisplayName("Enabled")]
		[Space(6f)]
		public BoolParameter colorBleedingEnabled;

		[Tooltip("This value allows to control the saturation of the color bleeding.")]
		[ColorBleedingSettings]
		[Space(10f)]
		public ClampedFloatParameter saturation;

		[Tooltip("Use masking on emissive pixels")]
		[ColorBleedingSettings]
		public ClampedFloatParameter brightnessMask;

		[Tooltip("Brightness level where masking starts/ends")]
		[ColorBleedingSettings]
		public MinMaxFloatParameter brightnessMaskRange;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableHBAO(bool enable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Preset GetCurrentPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyPreset(Preset preset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Mode GetMode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMode(Mode mode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RenderingPath GetRenderingPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRenderingPath(RenderingPath renderingPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quality GetQuality()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetQuality(Quality quality)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Deinterleaving GetDeinterleaving()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDeinterleaving(Deinterleaving deinterleaving)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Resolution GetResolution()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetResolution(Resolution resolution)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NoiseType GetNoiseType()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNoiseType(NoiseType noiseType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugMode GetDebugMode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDebugMode(DebugMode debugMode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoRadius()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoRadius(float radius)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoMaxRadiusPixels()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoMaxRadiusPixels(float maxRadiusPixels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoBias()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoBias(float bias)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoOffscreenSamplesContribution()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoOffscreenSamplesContribution(float offscreenSamplesContribution)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoMaxDistance()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoMaxDistance(float maxDistance)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoDistanceFalloff()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoDistanceFalloff(float distanceFalloff)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerPixelNormals GetAoPerPixelNormals()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoPerPixelNormals(PerPixelNormals perPixelNormals)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetAoColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoColor(Color baseColor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoIntensity()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoIntensity(float intensity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool UseMultiBounce()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableMultiBounce(bool enabled = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAoMultiBounceInfluence()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAoMultiBounceInfluence(float multiBounceInfluence)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsTemporalFilterEnabled()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableTemporalFilter(bool enabled = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VarianceClipping GetTemporalFilterVarianceClipping()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTemporalFilterVarianceClipping(VarianceClipping varianceClipping)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlurType GetBlurType()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlurType(BlurType blurType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetBlurSharpness()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlurSharpness(float sharpness)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsColorBleedingEnabled()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableColorBleeding(bool enabled = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetColorBleedingSaturation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorBleedingSaturation(float saturation)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetColorBleedingBrightnessMask()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorBleedingBrightnessMask(float brightnessMask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 GetColorBleedingBrightnessMaskRange()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorBleedingBrightnessMaskRange(Vector2 brightnessMaskRange)
		{
			throw null;
		}

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
		public HBAO()
		{
			throw null;
		}
	}
}
