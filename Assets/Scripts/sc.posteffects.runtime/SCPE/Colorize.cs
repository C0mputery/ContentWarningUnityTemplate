using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Image/Colorize")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Colorize //: VolumeComponent, IPostProcessComponent
	{
		public enum BlendMode
		{
			Linear = 0,
			Additive = 1,
			Multiply = 2,
			Screen = 3
		}

		[Serializable]
		public sealed class BlendModeParameter : VolumeParameter<BlendMode>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public BlendModeParameter()
//			{
//				throw null;
//			}
		}

		[Tooltip("Blends the gradient through various Photoshop-like blending modes")]
		public BlendModeParameter mode;

		[Range(0f, 1f)]
		[Tooltip("Fades the effect in or out")]
		public ClampedFloatParameter intensity;

		[Tooltip("Supply a gradient texture.\n\nLuminance values are colorized from left to right")]
		public TextureParameter colorRamp;

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
		public Colorize()
		{

		}
	}
}
