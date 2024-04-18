using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class EdgeStretch_RLPRO : ScriptableRendererFeature
{
	public class EdgeStretch_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int TimeV;

		private static readonly int _NoiseBottomHeightV;

		private static readonly int frequencyV;

		private static readonly int amplitudeV;

		private static readonly int speedV;

		private static readonly int TempTargetId;

		private EdgeStretch retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		private float T;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EdgeStretch_RLPROPass(RenderPassEvent evt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup(in RenderTargetIdentifier currentTarget)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Render(CommandBuffer cmd, ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ParamSwitch(Material mat, bool paramValue, string paramName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EdgeStretch_RLPROPass()
		{
			throw null;
		}
	}

	private EdgeStretch_RLPROPass RetroPass;

	public RenderPassEvent Event;

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
	public EdgeStretch_RLPRO()
	{

	}
}
