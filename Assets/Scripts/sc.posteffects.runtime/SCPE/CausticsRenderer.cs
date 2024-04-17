using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class CausticsRenderer : ScriptableRendererFeature
	{
		private class CausticsRenderPass : PostEffectRenderer<Caustics>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public CausticsRenderPass(EffectBaseSettings settings)
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
		public class Causticsettings : EffectBaseSettings
		{
			[Header("Effect specific")]
			[Tooltip("Executes the effect before transparent materials are rendered.")]
			public bool skipTransparents;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Causticsettings()
			{
				throw null;
			}
		}

		private CausticsRenderPass m_ScriptablePass;

		[SerializeField]
		public Causticsettings settings;

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
		public CausticsRenderer()
		{
			throw null;
		}
	}
}
