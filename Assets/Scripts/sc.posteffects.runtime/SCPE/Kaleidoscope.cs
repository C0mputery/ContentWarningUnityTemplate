using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Misc/Kaleidoscope")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Kaleidoscope //: VolumeComponent, IPostProcessComponent
	{
		[FormerlySerializedAs("splits")]
		[Range(0f, 10f)]
		[Tooltip("The number of times the screen is split up")]
		public ClampedIntParameter radialSplits;

		[Range(1f, 6f)]
		public ClampedIntParameter horizontalSplits;

		[Range(1f, 6f)]
		public ClampedIntParameter verticalSplits;

		[Tooltip("Sets the pivot point (screen center is [0.5, 0.5]).")]
		public Vector2Parameter center;

		[Space]
		public BoolParameter maintainAspectRatio;

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
		public Kaleidoscope()
		{

		}
	}
}
