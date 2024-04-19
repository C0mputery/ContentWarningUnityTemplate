using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Retro/Scanlines")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Scanlines //: VolumeComponent, IPostProcessComponent
	{
		[Range(0f, 1f)]
		[Tooltip("Intensity")]
		public ClampedFloatParameter intensity;

		[Range(0f, 1f)]
		[Tooltip("Lines")]
		public ClampedFloatParameter amount;

		[Range(-1f, 1f)]
		[Tooltip("Animation speed")]
		public ClampedFloatParameter speed;

		[SerializeField]
		public Shader shader;

//		[MethodImpl(MethodImplOptions.NoInlining)]
//		public bool IsActive()
//		{
//			throw null;
//		}

//		[MethodImpl(MethodImplOptions.NoInlining)]
//		public bool IsTileCompatible()
//		{
//			throw null;
//		}

//		[MethodImpl(MethodImplOptions.NoInlining)]
//		private void Reset()
//		{
//			throw null;
//		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SerializeShader()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Scanlines()
		{

		}
	}
}
