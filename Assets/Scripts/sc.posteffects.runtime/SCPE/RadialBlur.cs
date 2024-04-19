using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Blurring/Radial Blur")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class RadialBlur //: VolumeComponent, IPostProcessComponent
	{
		[Range(0f, 1f)]
		public ClampedFloatParameter amount;

		[Space]
		[Tooltip("Sets the blur center point (screen center is [0.5, 0.5]).")]
		public Vector2Parameter center;

		[Range(-180f, 180f)]
		public ClampedFloatParameter angle;

		[Space]
		[Range(3f, 12f)]
		public ClampedIntParameter iterations;

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
		public RadialBlur()
		{

		}
	}
}
