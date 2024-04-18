using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class LensFlaresRenderer : ScriptableRendererFeature
	{
		private class LensFlaresRenderPass : PostEffectRenderer<LensFlares>
		{
			private enum Pass
			{
				LuminanceDiff = 0,
				Ghosting = 1,
				Blur = 2,
				Blend = 3,
				Debug = 4
			}

			private int flaresTexID;

			private int emissionTexID;

			private RTHandle emissionTex;

			private RTHandle flaresTex;

			private RTHandle blurBuffer1;

			private RTHandle blurBuffer2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LensFlaresRenderPass(EffectBaseSettings settings)
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

		private LensFlaresRenderPass m_ScriptablePass;

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
		public LensFlaresRenderer()
		{

		}
	}
}
