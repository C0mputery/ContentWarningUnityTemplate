using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Warp_RLPRO : ScriptableRendererFeature
{
	public class Warp_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int fadeV;

		private static readonly int scaleV;

		private static readonly int warpV;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private static readonly int TempTargetId;

		private Warp retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Warp_RLPROPass(RenderPassEvent evt)
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
		static Warp_RLPROPass()
		{
			throw null;
		}
	}

	private Warp_RLPROPass RetroPass;

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
	public Warp_RLPRO()
	{

	}
}
