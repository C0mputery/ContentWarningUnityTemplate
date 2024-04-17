using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Screen/Ripples")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Ripples : VolumeComponent, IPostProcessComponent
	{
		public enum RipplesMode
		{
			Radial = 0,
			OmniDirectional = 1
		}

		[Serializable]
		public sealed class RipplesModeParam : VolumeParameter<RipplesMode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public RipplesModeParam()
			{
				throw null;
			}
		}

		public RipplesModeParam mode;

		public ClampedFloatParameter strength;

		[Range(1f, 10f)]
		[Tooltip("The frequency of the waves")]
		public ClampedFloatParameter distance;

		[Range(0f, 10f)]
		[Tooltip("Speed")]
		public ClampedFloatParameter speed;

		[Range(0f, 5f)]
		[Tooltip("Width")]
		public ClampedFloatParameter width;

		[Range(0f, 5f)]
		[Tooltip("Height")]
		public ClampedFloatParameter height;

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
		public Ripples()
		{
			throw null;
		}
	}
}
