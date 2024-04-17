using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class AmbientOcclusion2DRenderer : ScriptableRendererFeature
	{
		private class AmbientOcclusion2DRenderPass : PostEffectRenderer<AmbientOcclusion2D>
		{
			private enum Pass
			{
				LuminanceDiff = 0,
				Blur = 1,
				Blend = 2,
				Debug = 3
			}

			private int aoTexID;

			private RTHandle ao;

			private RTHandle blurBuffer1;

			private RTHandle blurBuffer2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AmbientOcclusion2DRenderPass(EffectBaseSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Setup(ScriptableRenderer renderer, RenderingData renderingData)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ConfigurePass(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void OnCameraCleanup(CommandBuffer cmd)
			{
				throw null;
			}
		}

		private AmbientOcclusion2DRenderPass m_ScriptablePass;

		[SerializeField]
		public EffectBaseSettings settings;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Create()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AmbientOcclusion2DRenderer()
		{
			throw null;
		}
	}
}
