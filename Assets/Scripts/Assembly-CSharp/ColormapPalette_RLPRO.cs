using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ColormapPalette_RLPRO : ScriptableRendererFeature
{
	public class ColormapPalette_RLPROPass : ScriptableRenderPass
	{
		private static readonly string k_RenderTag;

		private static readonly int MainTexId;

		private static readonly int heightV;

		private static readonly int widthV;

		private static readonly int _DitherV;

		private static readonly int _OpacityV;

		private static readonly int _BlueNoiseV;

		private static readonly int _PaletteV;

		private static readonly int _ColormapV;

		private static readonly int TempTargetId;

		private static readonly int _FadeMultiplier;

		private static readonly int _Mask;

		private ColormapPalette retroEffect;

		private Material RetroEffectMaterial;

		private RenderTargetIdentifier currentTarget;

		public int tempPresetIndex;

		private bool m_Init;

		private Texture2D colormapPalette;

		private Texture3D colormapTexture;

		private Vector2 m_Res;

		private int m_TempPixelSize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColormapPalette_RLPROPass(RenderPassEvent evt)
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
		public void ApplyMaterialVariables(Material bl, out Vector2 res)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyColormapToMaterial(Material bl)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ApplyPalette(Material bl)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyMap(Material bl)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool intHasChanged(int A, int B)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ColormapPalette_RLPROPass()
		{
			throw null;
		}
	}

	private ColormapPalette_RLPROPass RetroPass;

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
	public ColormapPalette_RLPRO()
	{
		throw null;
	}
}
