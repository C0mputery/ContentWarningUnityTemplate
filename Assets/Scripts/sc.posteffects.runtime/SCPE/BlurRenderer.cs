using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class BlurRenderer : ScriptableRendererFeature
	{
		private class BlurRenderPass : PostEffectRenderer<Blur>
		{
			private enum Pass
			{
				Blend = 0,
				BlendDepthFade = 1,
				Gaussian = 2,
				Box = 3
			}

			private RTHandle blurBuffer1;

			private RTHandle blurBuffer2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public BlurRenderPass(EffectBaseSettings settings)
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

		private BlurRenderPass m_ScriptablePass;

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
		public BlurRenderer()
		{

		}
	}
}
