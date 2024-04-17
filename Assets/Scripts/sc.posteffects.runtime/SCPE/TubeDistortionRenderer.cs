using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class TubeDistortionRenderer : ScriptableRendererFeature
	{
		private class TubeDistortionRenderPass : PostEffectRenderer<TubeDistortion>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TubeDistortionRenderPass(EffectBaseSettings settings)
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
		}

		private TubeDistortionRenderPass m_ScriptablePass;

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
		public TubeDistortionRenderer()
		{
			throw null;
		}
	}
}
