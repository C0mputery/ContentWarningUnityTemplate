using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using EPOOutline;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class URPOutlineFeature : ScriptableRendererFeature
{
	private class SRPOutline : ScriptableRenderPass
	{
		private static List<Outlinable> temporaryOutlinables;

		public ScriptableRenderer Renderer;

		public bool UseColorTargetForDepth;

		public Outliner Outliner;

		public OutlineParameters Parameters;

		private List<Outliner> outliners;

		private FieldInfo nameId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SRPOutline()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsDepthTextureAvailable(ScriptableRenderer renderer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private RenderTargetIdentifier GetDepthTarget(ScriptableRenderer renderer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private RenderTargetIdentifier GetColorTarget(ScriptableRenderer renderer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SRPOutline()
		{
			throw null;
		}
	}

	private class Pool
	{
		private Stack<SRPOutline> outlines;

		private List<SRPOutline> createdOutlines;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SRPOutline Get()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pool()
		{
			throw null;
		}
	}

	private GameObject lastSelectedCamera;

	private Pool outlinePool;

	private List<Outliner> outliners;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GetOutlinersToRenderWith(RenderingData renderingData, List<Outliner> outliners)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Create()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public URPOutlineFeature()
	{

	}
}
