using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VHSScanlines_RLPRO : ScriptableRendererFeature
{
	public class VHSScanlines_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int TimeV;

		private static readonly int _ScanLinesV;

		private static readonly int speedV;

		private static readonly int fadeV;

		private static readonly int _OffsetDistortionV;

		private static readonly int sfericalV;

		private static readonly int barrelV;

		private static readonly int scaleV;

		private static readonly int _ScanLinesColorV;

		private static readonly int TempTargetId;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private float T;

		private VHSScanlines retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VHSScanlines_RLPROPass(RenderPassEvent evt)
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
		static VHSScanlines_RLPROPass()
		{
			throw null;
		}
	}

	private VHSScanlines_RLPROPass RetroPass;

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
	public VHSScanlines_RLPRO()
	{

	}
}
