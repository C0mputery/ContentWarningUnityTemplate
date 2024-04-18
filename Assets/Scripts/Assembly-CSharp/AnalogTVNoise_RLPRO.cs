using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class AnalogTVNoise_RLPRO : ScriptableRendererFeature
{
	public class AnalogTVNoise_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int TimeXV;

		private static readonly int _PatternV;

		private static readonly int barHeightV;

		private static readonly int barSpeedV;

		private static readonly int cutV;

		private static readonly int edgeCutOffV;

		private static readonly int angleV;

		private static readonly int tileXV;

		private static readonly int tileYV;

		private static readonly int horizontalV;

		private static readonly int _OffsetNoiseXV;

		private static readonly int _OffsetNoiseYV;

		private static readonly int _FadeV;

		private static readonly int TempTargetId;

		private static readonly int _Mask;

		private static readonly int _FadeMultiplier;

		private AnalogTVNoise retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		private float TimeX;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnalogTVNoise_RLPROPass(RenderPassEvent evt)
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
		static AnalogTVNoise_RLPROPass()
		{
			throw null;
		}
	}

	private AnalogTVNoise_RLPROPass RetroPass;

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
	public AnalogTVNoise_RLPRO()
	{

	}
}
