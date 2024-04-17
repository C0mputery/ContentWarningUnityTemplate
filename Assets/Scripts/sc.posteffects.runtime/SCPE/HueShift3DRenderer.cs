using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class HueShift3DRenderer : ScriptableRendererFeature
	{
		private class HueShift3DRenderPass : PostEffectRenderer<HueShift3D>
		{
			private enum Pass
			{
				ColorSpectrum = 0,
				GradientTexture = 1
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HueShift3DRenderPass(EffectBaseSettings settings)
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

		[Serializable]
		public class HueShift3DSettings : EffectBaseSettings
		{
			[Header("Effect specific")]
			[Tooltip("Reconstruct the scene geometry's normals from the depth texture.\n\nIn Unity 2020.3+, disabling this will have the effect use the Depth-Normals prepass, which is more accurate. This will have all object re-render, if the scene isn't already optimized for draw calls, this will negatively affect performance")]
			public bool reconstructDepthNormals;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HueShift3DSettings()
			{
				throw null;
			}
		}

		private HueShift3DRenderPass m_ScriptablePass;

		[SerializeField]
		public HueShift3DSettings settings;

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
		public HueShift3DRenderer()
		{
			throw null;
		}
	}
}
