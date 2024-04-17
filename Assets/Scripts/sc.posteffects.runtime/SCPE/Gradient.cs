using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Screen/Gradient")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Gradient : VolumeComponent, IPostProcessComponent
	{
		public enum Mode
		{
			ColorFields = 0,
			Texture = 1
		}

		[Serializable]
		public sealed class GradientModeParameter : VolumeParameter<Mode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GradientModeParameter()
			{
				throw null;
			}
		}

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

		public ClampedFloatParameter intensity;

		public GradientModeParameter input;

		[Tooltip("The color's alpha channel controls its opacity")]
		public ColorParameter color1;

		[Tooltip("The color's alpha channel controls its opacity")]
		public ColorParameter color2;

		[Range(0f, 1f)]
		[Tooltip("Size")]
		public ClampedFloatParameter rotation;

		public TextureParameter gradientTex;

		[Tooltip("Blends the gradient through various Photoshop-like blending modes")]
		public BlendModeParameter mode;

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
		public Gradient()
		{
			throw null;
		}
	}
}
