using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	public class FogRenderer : ScriptableRendererFeature
	{
		private class FogRenderPass : PostEffectRenderer<Fog>
		{
			private enum Pass
			{
				Prefilter = 0,
				Downsample = 1,
				Upsample = 2,
				Blend = 3,
				BlendScattering = 4
			}

			private bool enableSkyboxCapture;

			private int skyboxTexID;

			private RTHandle skyboxColorRT;

			private static readonly Vector3[] skySphereVertices;

			private static readonly int[] skySphereTriangles;

			private static Mesh _SkySphere;

			private bool wasFogEnabed;

			private readonly int _SCPEFogEnabled;

			private static Mesh SkySphere
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FogRenderPass(FogSettings settings)
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

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FogRenderPass()
			{
				throw null;
			}
		}

		[Serializable]
		public class FogSettings : EffectBaseSettings
		{
			[Header("Effect specific")]
			[Tooltip("Executes the effect before transparent materials are rendered.")]
			public bool skipTransparents;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FogSettings()
			{
				throw null;
			}
		}

		private FogRenderPass fogRenderPass;

		[SerializeField]
		public FogSettings settings;

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
		public FogRenderer()
		{

		}
	}
}
