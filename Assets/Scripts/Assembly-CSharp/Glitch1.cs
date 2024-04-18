using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Glitch1 : ScriptableRendererFeature
{
	public class Glitch1Pass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int Strength;

		private static readonly int x;

		private static readonly int y;

		private static readonly int angleY;

		private static readonly int Stretch;

		private static readonly int Speed;

		private static readonly int mR;

		private static readonly int mG;

		private static readonly int mB;

		private static readonly int Fade;

		private static readonly int m_T;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private static readonly int TempTargetId;

		private LimitlessGlitch1 glitch1;

		private Material Glitch1Material;

		private RenderTargetIdentifier currentTarget;

		private float T;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Glitch1Pass(RenderPassEvent evt)
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
		static Glitch1Pass()
		{
			throw null;
		}
	}

	private Glitch1Pass GlitchPass;

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
	public Glitch1()
	{

	}
}
