using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Environment/Cloud Shadows")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class CloudShadows : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("The red channel of this texture is used to sample the clouds")]
		public TextureParameter texture;

		[Space]
		[Range(0f, 1f)]
		public ClampedFloatParameter size;

		[Range(0f, 1f)]
		public ClampedFloatParameter density;

		[Range(0f, 1f)]
		public ClampedFloatParameter speed;

		[Tooltip("Set the X and Z world-space direction the clouds should move in")]
		public Vector2Parameter direction;

		public BoolParameter projectFromSun;

		public FloatParameter startFadeDistance;

		public FloatParameter endFadeDistance;

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
		public CloudShadows()
		{

		}
	}
}
