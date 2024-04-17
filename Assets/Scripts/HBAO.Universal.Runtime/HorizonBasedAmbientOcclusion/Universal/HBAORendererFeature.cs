using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR;

namespace HorizonBasedAmbientOcclusion.Universal
{
	public class HBAORendererFeature : ScriptableRendererFeature
	{
		private class HBAORenderPass : ScriptableRenderPass
		{
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

				public const int Debug_ViewNormals = 10;
			}

			private static class ShaderProperties
			{
				public static int mainTex;

				public static int inputTex;

				public static int hbaoTex;

				public static int tempTex;

				public static int tempTex2;

				public static int noiseTex;

				public static int depthTex;

				public static int normalsTex;

				public static int ssaoTex;

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

				public static int historyBufferRTHandleScale;

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ShaderProperties()
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetOrthographicProjectionKeyword(bool orthographic)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetQualityKeyword(HBAO.Quality quality)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetNoiseKeyword(HBAO.NoiseType noiseType)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetDeinterleavingKeyword(HBAO.Deinterleaving deinterleaving)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetDebugKeyword(HBAO.DebugMode debugMode)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetMultibounceKeyword(bool useMultiBounce, bool litAoModeEnabled)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetOffscreenSamplesContributionKeyword(float offscreenSamplesContribution)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetPerPixelNormalsKeyword(HBAO.PerPixelNormals perPixelNormals)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetBlurRadiusKeyword(HBAO.BlurType blurType)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetVarianceClippingKeyword(HBAO.VarianceClipping varianceClipping)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetColorBleedingKeyword(bool colorBleedingEnabled, bool litAoModeEnabled)
				{
					throw null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public static string GetModeKeyword(HBAO.Mode mode)
				{
					throw null;
				}
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

			private class CameraHistoryBuffers
			{
				public CameraData cameraData
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

				public BufferedRTHandleSystem historyRTSystem
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

				public int frameCount
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

				public int lastRenderedFrame
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

				[MethodImpl(MethodImplOptions.NoInlining)]
				public CameraHistoryBuffers()
				{
					throw null;
				}
			}

			private enum HistoryBufferType
			{
				AmbientOcclusion = 0,
				ColorBleeding = 1
			}

			public HBAO hbao;

			private static readonly Vector2[] s_jitter;

			private static readonly float[] s_temporalRotations;

			private static readonly float[] s_temporalOffsets;

			private Mesh m_FullscreenTriangle;

			private HBAO.Resolution? m_PreviousResolution;

			private HBAO.NoiseType? m_PreviousNoiseType;

			private bool m_PreviousColorBleedingEnabled;

			private XRSettings.StereoRenderingMode m_PrevStereoRenderingMode;

			private string[] m_ShaderKeywords;

			private RenderTargetIdentifier[] m_RtsDepth;

			private RenderTargetIdentifier[] m_RtsNormals;

			private List<CameraHistoryBuffers> m_CameraHistoryBuffers;

			private Vector4[] m_UVToViewPerEye;

			private float[] m_RadiusPerEye;

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

			private RenderTargetIdentifier source
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

			private CameraData cameraData
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

			private RenderTextureDescriptor sourceDesc
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

			private RenderTextureDescriptor aoDesc
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

			private RenderTextureDescriptor deinterleavedDepthDesc
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

			private RenderTextureDescriptor deinterleavedNormalsDesc
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

			private RenderTextureDescriptor deinterleavedAoDesc
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

			private RenderTextureDescriptor reinterleavedAoDesc
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

			private RenderTextureFormat colorFormat
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

			private GraphicsFormat graphicsColorFormat
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

			private RenderTextureFormat depthFormat
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

			private RenderTextureFormat normalsFormat
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

			private Mesh fullscreenTriangle
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FillSupportedRenderTextureFormats()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Setup(Shader shader, ScriptableRenderer renderer, RenderingData renderingData)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FrameCleanup(CommandBuffer cmd)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Cleanup()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void FetchVolumeComponent()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void FetchRenderParameters(RenderTextureDescriptor cameraTextureDesc)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private RTHandle HistoryBufferAllocator(RTHandleSystem rtHandleSystem, int frameIndex)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void AllocCameraHistoryBuffers(ref CameraHistoryBuffers buffers)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void ReleaseCameraHistoryBuffers(ref CameraHistoryBuffers buffers)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private CameraHistoryBuffers GetCurrentCameraHistoryBuffers()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void CopySource(CommandBuffer cmd)
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
			private void TemporalFilter(CommandBuffer cmd, CameraHistoryBuffers buffers)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void Composite(CommandBuffer cmd)
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
			private RenderTextureDescriptor GetStereoCompatibleDescriptor(int width, int height, RenderTextureFormat format = RenderTextureFormat.Default, int depthBufferBits = 0, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Rect viewportRect, Material material, int passIndex = 0)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, Material material, int passIndex = 0)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, Rect viewportRect, Material material, int passIndex = 0)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void BlitFullscreenTriangleWithClear(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, Color clearColor, int passIndex = 0)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private Vector2 AdjustBrightnessMaskToGammaSpace(Vector2 v)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private float ToGammaSpace(float v)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private Vector2 ToGammaSpace(Vector2 v)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void CreateNoiseTexture()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HBAORenderPass()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HBAORenderPass()
			{
				throw null;
			}
		}

		[SerializeField]
		[HideInInspector]
		private Shader shader;

		private HBAORenderPass m_HBAORenderPass;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Create()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HBAORendererFeature()
		{
			throw null;
		}
	}
}
