using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class LowRes_RLPRO : ScriptableRendererFeature
{
	public class LowRes_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int HeightV;

		private static readonly int WidthV;

		private static readonly int TempTargetId;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private LowRes retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LowRes_RLPROPass(RenderPassEvent evt)
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
		static LowRes_RLPROPass()
		{
			throw null;
		}
	}

	private LowRes_RLPROPass RetroPass;

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
	public LowRes_RLPRO()
	{

	}
}
