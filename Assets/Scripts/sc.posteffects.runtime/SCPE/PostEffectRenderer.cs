using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[DisallowMultipleRendererFeature(null)]
	public class PostEffectRenderer<T> : ScriptableRenderPass
	{
		public bool render;

		public T volumeSettings;

		public EffectBaseSettings settings;

		private static bool is2D;

		private static bool isDeferred;

		private bool xrRendering;

		protected bool requiresDepth;

		protected bool requiresDepthNormals;

		protected string shaderName;

		private Shader shader;

		protected string ProfilerTag;

		protected Material Material;

		private static Material _BlitMaterial;

		private static RTHandle cameraColorSource;

		protected RTHandle cameraColorTarget;

		private RenderTextureDescriptor cameraTargetRtDsc;

		private static RenderTextureDescriptor tempRTDesc;

		private int mainTexID;

		public bool reconstructDepthNormals;

		private int depthNormalsID;

		private static RTHandle cameraNormalsTexture;

		private readonly ProfilingSampler bufferCopyProfiler;

		private readonly ProfilingSampler depthNormalsProfiler;

		private static int prevRendererID;

		private static int currentRendererID;

		private ScriptableRenderPassInput requirements;

		private Material DepthNormalsMat;

		private static Shader DepthNormalsShader;

		private static Vector4 ScaleBias;

		private static bool isPlaying;

		private static Matrix4x4 lightToLocalMatrix;

		private static readonly int viewProjection;

		private static readonly int viewMatrix;

		private static Matrix4x4[] s_viewProjectionMatrices;

		private static readonly int viewProjectionArray;

		private bool RequireBufferCopy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static Material BlitMaterial
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string GetProfilerTag()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DetermineRendererType(ScriptableRenderer renderer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Setup(ScriptableRenderer renderer, RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RTHandle GetCameraTarget(ScriptableRenderer renderer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCameraTarget(ScriptableRenderer renderer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsAllowedCameraType(EffectBaseSettings.CameraTypeFlags flag)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ShouldRenderForCamera(RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateMaterialIfNull(ref Material material, Shader m_shader)
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
		private static RTHandle AllocateRT(RenderTextureDescriptor cameraTextureDescriptor, GraphicsFormat format, FilterMode filterMode, string name, int downsampling = 1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReleaseRT(RTHandle handle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool RTHandleNeedsReAlloc(RTHandle handle, in RenderTextureDescriptor descriptor, in string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RTHandle GetTemporaryRT(ref RTHandle handle, RenderTextureDescriptor cameraTextureDescriptor, GraphicsFormat format, FilterMode filterMode, string name, int downsampling = 1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ConfigurePass(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CommandBuffer GetCommandBuffer(ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetCameraColorTarget(RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CopyTargets(CommandBuffer cmd, RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GenerateDepthNormals(ScriptableRenderPass pass, CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void BlitCopy(CommandBuffer cmd, RTHandle source, RTHandle dest)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Blit(ScriptableRenderPass pass, CommandBuffer cmd, RTHandle source, RTHandle target, Material mat, int passIndex, bool clearColor = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void FinalBlit(ScriptableRenderPass pass, ScriptableRenderContext context, CommandBuffer cmd, RenderingData renderingData, int passIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool ShouldReleaseRT()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMainLightProjection(CommandBuffer cmd, RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetViewProjectionMatrixUniforms(CommandBuffer cmd, in CameraData cameraData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PostEffectRenderer()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PostEffectRenderer()
		{
			throw null;
		}
	}
}
