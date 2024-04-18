using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VHSEffect_RLPRO : ScriptableRendererFeature
{
	public class VHSEffect_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int TimeV;

		private static readonly int _OffsetPosY;

		private static readonly int smoothSize;

		private static readonly int _StandardDeviation;

		private static readonly int iterations;

		private static readonly int tileX;

		private static readonly int smooth;

		private static readonly int tileY;

		private static readonly int _OffsetDistortion;

		private static readonly int _Stripes;

		private static readonly int _OffsetColorAngle;

		private static readonly int _OffsetColor;

		private static readonly int _OffsetNoiseX;

		private static readonly int _SecondaryTex;

		private static readonly int _OffsetNoiseY;

		private static readonly int _TexIntensity;

		private static readonly int _TexCut;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private static readonly int TempTargetId;

		private float T;

		private VHSEffect retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VHSEffect_RLPROPass(RenderPassEvent evt)
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
		static VHSEffect_RLPROPass()
		{
			throw null;
		}
	}

	private VHSEffect_RLPROPass RetroPass;

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
	public VHSEffect_RLPRO()
	{

	}
}
