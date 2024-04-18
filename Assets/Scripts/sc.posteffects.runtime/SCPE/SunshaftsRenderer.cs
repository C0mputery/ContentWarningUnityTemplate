using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class SunshaftsRenderer : ScriptableRendererFeature
	{
		private class SunshaftsRenderPass : PostEffectRenderer<Sunshafts>
		{
			public enum Pass
			{
				SkySource = 0,
				RadialBlur = 1,
				Blend = 2
			}

			private int skyboxBufferID;

			private RTHandle blurBuffer1;

			private RTHandle blurBuffer2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SunshaftsRenderPass(EffectBaseSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Setup(ScriptableRenderer renderer, RenderingData renderingData)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
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

		private SunshaftsRenderPass m_ScriptablePass;

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
		public SunshaftsRenderer()
		{

		}
	}
}
