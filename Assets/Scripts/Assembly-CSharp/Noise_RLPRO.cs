using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Noise_RLPRO : ScriptableRendererFeature
{
	public class Noise_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int alphaTexV;

		private static readonly int _AlphaMapTexV;

		private static readonly int tapeLinesAmountV;

		private static readonly int time_V;

		private static readonly int screenLinesNumV;

		private static readonly int noiseLinesNumV;

		private static readonly int noiseQuantizeXV;

		private static readonly int signalNoisePowerV;

		private static readonly int signalNoiseAmountV;

		private static readonly int filmGrainAmountV;

		private static readonly int tapeNoiseTHV;

		private static readonly int tapeNoiseAmountV;

		private static readonly int tapeNoiseSpeedV;

		private static readonly int lineNoiseAmountV;

		private static readonly int lineNoiseSpeedV;

		private static readonly int _TapeTexV;

		private static readonly int TempTargetId;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private Noise retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		private float _time;

		private RenderTexture texTape;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Noise_RLPROPass(RenderPassEvent evt)
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
		static Noise_RLPROPass()
		{
			throw null;
		}
	}

	private Noise_RLPROPass RetroPass;

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
	public Noise_RLPRO()
	{
		throw null;
	}
}
