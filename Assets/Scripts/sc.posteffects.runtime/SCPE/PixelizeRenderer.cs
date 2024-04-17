using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class PixelizeRenderer : ScriptableRendererFeature
	{
		private class PixelizeRenderPass : PostEffectRenderer<Pixelize>
		{
			private static readonly int _PixelizeParams;

			private static Vector4 pixelizeParams;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PixelizeRenderPass(EffectBaseSettings settings)
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
			static PixelizeRenderPass()
			{
				throw null;
			}
		}

		private PixelizeRenderPass m_ScriptablePass;

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
		public void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PixelizeRenderer()
		{
			throw null;
		}
	}
}