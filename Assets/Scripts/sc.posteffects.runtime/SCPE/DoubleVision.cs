using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Blurring/Double Vision")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class DoubleVision : VolumeComponent, IPostProcessComponent
	{
		public enum Mode
		{
			FullScreen = 0,
			Edges = 1
		}

		[Serializable]
		public sealed class DoubleVisionMode : VolumeParameter<Mode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public DoubleVisionMode()
			{
				throw null;
			}
		}

		[Tooltip("Choose to apply the effect over the entire screen or just the edges")]
		public DoubleVisionMode mode;

		[Range(0f, 1f)]
		[Tooltip("Intensity")]
		public ClampedFloatParameter intensity;

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
		public DoubleVision()
		{
			throw null;
		}
	}
}
