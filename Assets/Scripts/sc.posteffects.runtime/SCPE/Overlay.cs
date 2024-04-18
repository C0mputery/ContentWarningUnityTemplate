using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Screen/Overlay")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Overlay : VolumeComponent, IPostProcessComponent
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			public BlendModeParameter()
			{
				throw null;
			}
		}

		public TextureParameter overlayTex;

		public ClampedFloatParameter intensity;

		[Tooltip("The screen's luminance values control the opacity of the image")]
		public ClampedFloatParameter luminanceThreshold;

		[Tooltip("Maintains the image aspect ratio, regardless of the screen width")]
		public BoolParameter autoAspect;

		[Tooltip("Blends the gradient through various Photoshop-like blending modes")]
		public BlendModeParameter blendMode;

		[Range(0f, 1f)]
		public ClampedFloatParameter tiling;

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
		public Overlay()
		{

		}
	}
}
