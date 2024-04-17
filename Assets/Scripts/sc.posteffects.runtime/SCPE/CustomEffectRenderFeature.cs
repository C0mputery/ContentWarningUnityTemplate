using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class CustomEffectRenderFeature : ScriptableRendererFeature
	{
		public class CustomEffectPass : PostEffectRenderer<VolumeComponent>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public CustomEffectPass(PostEffectSettings settings)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Setup(ScriptableRenderer renderer, RenderingData renderingData)
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
		public class PostEffectSettings : EffectBaseSettings
		{
			[Space]
			public Material material;

			[Tooltip("Executes the effect before transparent materials are rendered.")]
			public bool skipTransparents;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PostEffectSettings()
			{
				throw null;
			}
		}

		private CustomEffectPass m_ScriptablePass;

		[SerializeField]
		public PostEffectSettings settings;

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
		public CustomEffectRenderFeature()
		{
			throw null;
		}
	}
}
