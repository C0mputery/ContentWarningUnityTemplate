using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Image/Sharpen")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Sharpen : VolumeComponent, IPostProcessComponent
	{
		public enum Method
		{
			[InspectorName("Luminance Enhancement (4 samples)")]
			LuminanceEnhancement = 0,
			[InspectorName("Contrast Adaptive (9 samples)")]
			ContrastAdaptive = 1
		}

		[Serializable]
		public sealed class MethodParam : VolumeParameter<Method>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public MethodParam()
			{
				throw null;
			}
		}

		public MethodParam mode;

		public ClampedFloatParameter amount;

		public ClampedFloatParameter radius;

		public ClampedFloatParameter contrast;

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
		public Sharpen()
		{
			throw null;
		}
	}
}
