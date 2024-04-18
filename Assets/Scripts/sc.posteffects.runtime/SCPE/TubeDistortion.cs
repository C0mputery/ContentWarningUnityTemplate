using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Screen/Tube Distortion")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class TubeDistortion : VolumeComponent, IPostProcessComponent
	{
		public enum DistortionMode
		{
			Buldged = 0,
			Pinched = 1,
			Beveled = 2
		}

		[Serializable]
		public sealed class DistortionModeParam : VolumeParameter<DistortionMode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public DistortionModeParam()
			{
				throw null;
			}
		}

		public DistortionModeParam mode;

		[Range(0f, 1f)]
		public ClampedFloatParameter amount;

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
		public TubeDistortion()
		{

		}
	}
}
