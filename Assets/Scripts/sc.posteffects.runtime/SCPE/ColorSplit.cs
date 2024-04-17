using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Retro/Color Split")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class ColorSplit : VolumeComponent, IPostProcessComponent
	{
		public enum SplitMode
		{
			[InspectorName("Horizontal")]
			Single = 0,
			[InspectorName("Horizontal + Vertical")]
			Double = 1
		}

		[Serializable]
		public sealed class SplitModeParam : VolumeParameter<SplitMode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public SplitModeParam()
			{
				throw null;
			}
		}

		[Tooltip("Box filtered methods provide a subtle blur effect and are less efficient")]
		public SplitModeParam mode;

		[Range(0f, 1f)]
		[Tooltip("The amount by which the color channels offset")]
		public FloatParameter offset;

		[Tooltip("0=Full screen. 1=Limit to screen edges")]
		public ClampedFloatParameter edgeMasking;

		[Range(0f, 3f)]
		[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
		public ClampedFloatParameter luminanceThreshold;

		[SerializeField]
		public Shader shader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsTileCompatible()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SerializeShader()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorSplit()
		{
			throw null;
		}
	}
}
