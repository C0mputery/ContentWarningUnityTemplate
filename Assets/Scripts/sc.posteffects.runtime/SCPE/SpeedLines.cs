using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Screen/Speed Lines")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class SpeedLines : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Assign any grayscale texture with a vertically repeating pattern and a falloff from left to right")]
		public TextureParameter noiseTex;

		public ClampedFloatParameter intensity;

		[Range(0f, 1f)]
		[Tooltip("Determines the radial tiling of the noise texture")]
		public ClampedFloatParameter size;

		[Range(0f, 1f)]
		public ClampedFloatParameter falloff;

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
		private bool SerializeShader()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpeedLines()
		{
			throw null;
		}
	}
}
