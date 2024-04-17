using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HorizonBasedAmbientOcclusion
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("Image Effects/HBAO")]
	[RequireComponent(typeof(Camera))]
	public class HBAO : MonoBehaviour
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

		public enum PipelineStage
		{
			BeforeImageEffectsOpaque = 0,
			AfterLighting = 1,
			BeforeReflections = 2
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
			GBuffer = 0,
			Camera = 1,
			Reconstruct = 2
		}

		public enum VarianceClipping
		{
			Disabled = 0,
			_4Tap = 1,
			_8Tap = 2
		}

		[Serializable]
		public struct Presets
		{
			public Preset preset;

			[SerializeField]
			public static Presets defaults
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		[Serializable]
		public struct GeneralSettings
		{
			[Tooltip("The stage the AO is injected into the rendering pipeline.")]
			[Space(6f)]
			public PipelineStage pipelineStage;

			[Tooltip("The quality of the AO.")]
			[Space(10f)]
			public Quality quality;

			[Tooltip("The deinterleaving factor.")]
			public Deinterleaving deinterleaving;

			[Tooltip("The resolution at which the AO is calculated.")]
			public Resolution resolution;

			[Tooltip("The type of noise to use.")]
			[Space(10f)]
			public NoiseType noiseType;

			[Tooltip("The debug mode actually displayed on screen.")]
			[Space(10f)]
			public DebugMode debugMode;

			[SerializeField]
			public static GeneralSettings defaults
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		[Serializable]
		public struct AOSettings
		{
			[Tooltip("AO radius: this is the distance outside which occluders are ignored.")]
			[Space(6f)]
			[Range(0.25f, 5f)]
			public float radius;

			[Tooltip("Maximum radius in pixels: this prevents the radius to grow too much with close-up object and impact on performances.")]
			[Range(16f, 256f)]
			public float maxRadiusPixels;

			[Tooltip("For low-tessellated geometry, occlusion variations tend to appear at creases and ridges, which betray the underlying tessellation. To remove these artifacts, we use an angle bias parameter which restricts the hemisphere.")]
			[Range(0f, 0.5f)]
			public float bias;

			[Tooltip("This value allows to scale up the ambient occlusion values.")]
			[Range(0f, 4f)]
			public float intensity;

			[Tooltip("Enable/disable MultiBounce approximation.")]
			public bool useMultiBounce;

			[Tooltip("MultiBounce approximation influence.")]
			[Range(0f, 1f)]
			public float multiBounceInfluence;

			[Tooltip("The amount of AO offscreen samples are contributing.")]
			[Range(0f, 1f)]
			public float offscreenSamplesContribution;

			[Tooltip("The max distance to display AO.")]
			[Space(10f)]
			public float maxDistance;

			[Tooltip("The distance before max distance at which AO start to decrease.")]
			public float distanceFalloff;

			[Tooltip("The type of per pixel normals to use.")]
			[Space(10f)]
			public PerPixelNormals perPixelNormals;

			[Tooltip("This setting allow you to set the base color if the AO, the alpha channel value is unused.")]
			[Space(10f)]
			public Color baseColor;

			[SerializeField]
			public static AOSettings defaults
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		[Serializable]
		public struct TemporalFilterSettings
		{
			[Space(6f)]
			public bool enabled;

			[Tooltip("The type of variance clipping to use.")]
			public VarianceClipping varianceClipping;

			[SerializeField]
			public static TemporalFilterSettings defaults
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		[Serializable]
		public struct BlurSettings
		{
			[Tooltip("The type of blur to use.")]
			[Space(6f)]
			public BlurType type;

			[Tooltip("This parameter controls the depth-dependent weight of the bilateral filter, to avoid bleeding across edges. A zero sharpness is a pure Gaussian blur. Increasing the blur sharpness removes bleeding by using lower weights for samples with large depth delta from the current pixel.")]
			[Space(10f)]
			[Range(0f, 16f)]
			public float sharpness;

			[SerializeField]
			public static BlurSettings defaults
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		[Serializable]
		public struct ColorBleedingSettings
		{
			[Space(6f)]
			public bool enabled;

			[Tooltip("This value allows to control the saturation of the color bleeding.")]
			[Space(10f)]
			[Range(0f, 4f)]
			public float saturation;

			[Tooltip("This value allows to scale the contribution of the color bleeding samples.")]
			[Range(0f, 32f)]
			public float albedoMultiplier;

			[Tooltip("Use masking on emissive pixels")]
			[Range(0f, 1f)]
			public float brightnessMask;

			[Tooltip("Brightness level where masking starts/ends")]
			[MinMaxSlider(0f, 2f)]
			public Vector2 brightnessMaskRange;

			[SerializeField]
			public static ColorBleedingSettings defaults
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public SettingsGroup()
			{
				throw null;
			}
		}

		public class MinMaxSliderAttribute : PropertyAttribute
		{
			public readonly float max;

			public readonly float min;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MinMaxSliderAttribute(float min, float max)
			{
				throw null;
			}
		}

		private static class Pass
		{
			public const int AO = 0;

			public const int AO_Deinterleaved = 1;

			public const int Deinterleave_Depth = 2;

			public const int Deinterleave_Normals = 3;

			public const int Atlas_AO_Deinterleaved = 4;

			public const int Reinterleave_AO = 5;

			public const int Blur = 6;

			public const int Temporal_Filter = 7;

			public const int Copy = 8;

			public const int Composite = 9;

			public const int Composite_AfterLighting = 10;

			public const int Composite_BeforeReflections = 11;

			public const int Composite_BlendAO = 12;

			public const int Composite_BlendCB = 13;

			public const int Debug_ViewNormals = 14;
		}

		private static class ShaderProperties
		{
			public static int mainTex;

			public static int hbaoTex;

			public static int tempTex;

			public static int tempTex2;

			public static int noiseTex;

			public static int depthTex;

			public static int normalsTex;

			public static int[] depthSliceTex;

			public static int[] normalsSliceTex;

			public static int[] aoSliceTex;

			public static int[] deinterleaveOffset;

			public static int atlasOffset;

			public static int jitter;

			public static int uvTransform;

			public static int inputTexelSize;

			public static int aoTexelSize;

			public static int deinterleavedAOTexelSize;

			public static int reinterleavedAOTexelSize;

			public static int uvToView;

			public static int targetScale;

			public static int radius;

			public static int maxRadiusPixels;

			public static int negInvRadius2;

			public static int angleBias;

			public static int aoMultiplier;

			public static int intensity;

			public static int multiBounceInfluence;

			public static int offscreenSamplesContrib;

			public static int maxDistance;

			public static int distanceFalloff;

			public static int baseColor;

			public static int colorBleedSaturation;

			public static int albedoMultiplier;

			public static int colorBleedBrightnessMask;

			public static int colorBleedBrightnessMaskRange;

			public static int blurDeltaUV;

			public static int blurSharpness;

			public static int temporalParams;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ShaderProperties()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetOrthographicOrDeferredKeyword(bool orthographic, GeneralSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetQualityKeyword(GeneralSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetNoiseKeyword(GeneralSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetDeinterleavingKeyword(GeneralSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetDebugKeyword(GeneralSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetMultibounceKeyword(AOSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetOffscreenSamplesContributionKeyword(AOSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetPerPixelNormalsKeyword(AOSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetBlurRadiusKeyword(BlurSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetVarianceClippingKeyword(TemporalFilterSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetColorBleedingKeyword(ColorBleedingSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetLightingLogEncodedKeyword(bool hdr)
			{
				throw null;
			}
		}

		public enum StereoRenderingMode
		{
			MultiPass = 0,
			SinglePassInstanced = 1
		}

		private static class MersenneTwister
		{
			public static float[] Numbers;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MersenneTwister()
			{
				throw null;
			}
		}

		public Shader hbaoShader;

		[SerializeField]
		[SettingsGroup]
		private Presets m_Presets;

		[SerializeField]
		[SettingsGroup]
		private GeneralSettings m_GeneralSettings;

		[SerializeField]
		[SettingsGroup]
		private AOSettings m_AOSettings;

		[SerializeField]
		[SettingsGroup]
		private TemporalFilterSettings m_TemporalFilterSettings;

		[SerializeField]
		[SettingsGroup]
		private BlurSettings m_BlurSettings;

		[SerializeField]
		[SettingsGroup]
		private ColorBleedingSettings m_ColorBleedingSettings;

		private static readonly Vector2[] s_jitter;

		private static readonly float[] s_temporalRotations;

		private static readonly float[] s_temporalOffsets;

		private RenderTextureDescriptor m_sourceDescriptor;

		private string[] m_ShaderKeywords;

		private Vector4[] m_UVToViewPerEye;

		private float[] m_RadiusPerEye;

		private bool m_IsCommandBufferDirty;

		private Mesh m_FullscreenTriangle;

		private PipelineStage? m_PreviousPipelineStage;

		private Resolution? m_PreviousResolution;

		private Deinterleaving? m_PreviousDeinterleaving;

		private DebugMode? m_PreviousDebugMode;

		private NoiseType? m_PreviousNoiseType;

		private BlurType? m_PreviousBlurAmount;

		private int m_PreviousWidth;

		private int m_PreviousHeight;

		private bool m_PreviousAllowHDR;

		private bool m_PreviousUseMultibounce;

		private bool m_PreviousColorBleedingEnabled;

		private bool m_PreviousTemporalFilterEnabled;

		private RenderingPath m_PreviousRenderingPath;

		private StereoRenderingMode m_PrevStereoRenderingMode;

		public Presets presets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public GeneralSettings generalSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public AOSettings aoSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public TemporalFilterSettings temporalFilterSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public BlurSettings blurSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public ColorBleedingSettings colorBleedingSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		private Material material
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private Camera hbaoCamera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private CommandBuffer cmdBuffer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int width
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int height
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private bool stereoActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int xrActiveEye
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private StereoRenderingMode stereoRenderingMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int screenWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int screenHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int aoWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int aoHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int reinterleavedAoWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int reinterleavedAoHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int deinterleavedAoWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int deinterleavedAoHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private int frameCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private bool motionVectorsSupported
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private RenderTexture aoHistoryBuffer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private RenderTexture colorBleedingHistoryBuffer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private Texture2D noiseTex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private Mesh fullscreenTriangle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private CameraEvent cameraEvent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private bool isCommandBufferDirty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		private bool isHistoryBufferDirty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static RenderTextureFormat defaultHDRRenderTextureFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private RenderTextureFormat sourceFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static RenderTextureFormat colorFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static RenderTextureFormat depthFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static RenderTextureFormat normalsFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static bool isLinearColorSpace
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private bool renderingInSceneView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
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
		public PipelineStage GetPipelineStage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPipelineStage(PipelineStage pipelineStage)
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
		public void SetAoOffscreenSamplesContribution(float contribution)
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
		public void SetAoColor(Color color)
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
		public float GetColorBleedingAlbedoMultiplier()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorBleedingAlbedoMultiplier(float albedoMultiplier)
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
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPreRender()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPostRender()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FetchRenderParameters()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AllocateHistoryBuffers()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReleaseHistoryBuffers()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearCommandBuffer(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BuildCommandBuffer(CommandBuffer cmd, CameraEvent cameraEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AO(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeinterleavedAO(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Blur(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TemporalFilter(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Composite(CommandBuffer cmd, CameraEvent cameraEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompositeBeforeReflections(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompositeAfterLighting(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompositeBeforeImageEffectsOpaque(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompositeDebug(CommandBuffer cmd, int finalPassId = 9)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateMaterialProperties()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateShaderKeywords()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckParameters()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private RenderTextureDescriptor GetDefaultDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private RenderTexture GetScreenSpaceRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReleaseTemporaryRT(CommandBuffer cmd, int nameID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, Material material, int pass = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BlitFullscreenTriangleWithClear(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, Color clearColor, int pass = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ApplyFlip(CommandBuffer cmd, bool flip = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector2 AdjustBrightnessMaskToGammaSpace(Vector2 v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float ToGammaSpace(float v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector2 ToGammaSpace(Vector2 v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateNoiseTexture()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HBAO()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HBAO()
		{
			throw null;
		}
	}
}
