using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Glitch2 : ScriptableRendererFeature
{
	public class Glitch2Pass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private static readonly int TempTargetId;

		private static readonly int _trashFrame1Id;

		private static readonly int _trashFrame2Id;

		private static readonly int _trashFrameId;

		private bool done;

		private LimitlessGlitch2 Glitch2;

		private Material Glitch2Material;

		private RenderTargetIdentifier currentTarget;

		private Texture2D _noiseTexture;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Glitch2Pass(RenderPassEvent evt)
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
		private void SetUpResources(float g_2Res)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateNoiseTexture(float g_2Res)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Color RandomColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Glitch2Pass()
		{
			throw null;
		}
	}

	private Glitch2Pass GlitchPass;

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
	public Glitch2()
	{
		throw null;
	}
}
