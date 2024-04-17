using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Image/3D Hue Shift")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class HueShift3D : VolumeComponent, IPostProcessComponent
	{
		public enum ColorSource
		{
			RGBSpectrum = 0,
			GradientTexture = 1
		}

		[Serializable]
		public sealed class ColorSourceParameter : VolumeParameter<ColorSource>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ColorSourceParameter()
			{
				throw null;
			}
		}

		[Tooltip("Box blurring uses fewer texture samples but has a limited blur range")]
		public ColorSourceParameter colorSource;

		public TextureParameter gradientTex;

		[Range(0f, 1f)]
		public ClampedFloatParameter intensity;

		[Range(0f, 1f)]
		[Tooltip("Speed")]
		public ClampedFloatParameter speed;

		[Range(0f, 3f)]
		[Tooltip("Size")]
		public ClampedFloatParameter size;

		[Range(0f, 10f)]
		[Tooltip("Bends the effect over the scene's geometry normals\n\nHigh values may induce banding artifacts")]
		public ClampedFloatParameter geoInfluence;

		public static bool isOrtho;

		[SerializeField]
		public Shader DepthNormalsShader;

		[SerializeField]
		public Shader shader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RequireDepthNormals()
		{
			throw null;
		}

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
		public HueShift3D()
		{
			throw null;
		}
	}
}
