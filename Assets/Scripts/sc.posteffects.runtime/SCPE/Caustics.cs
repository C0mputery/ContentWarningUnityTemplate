using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Environment/Caustics")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Caustics //: VolumeComponent, IPostProcessComponent
	{
		public ClampedFloatParameter intensity;

		public TextureParameter causticsTexture;

		public FloatParameter brightness;

		public ClampedFloatParameter luminanceThreshold;

		public BoolParameter projectFromSun;

		public FloatParameter minHeight;

		public ClampedFloatParameter minHeightFalloff;

		public FloatParameter maxHeight;

		public ClampedFloatParameter maxHeightFalloff;

		public ClampedFloatParameter size;

		public ClampedFloatParameter speed;

		public BoolParameter distanceFade;

		public FloatParameter startFadeDistance;

		public FloatParameter endFadeDistance;

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
		public Caustics()
		{

		}
	}
}
