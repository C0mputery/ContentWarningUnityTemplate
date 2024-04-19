using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Stylized/Kuwahara")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Kuwahara //: VolumeComponent, IPostProcessComponent
	{
		public enum KuwaharaMode
		{
			FullScreen = 0,
			DepthFade = 1
		}

		[Serializable]
		public sealed class KuwaharaModeParam : VolumeParameter<KuwaharaMode>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public KuwaharaModeParam()
//			{
//				throw null;
//			}
		}

		[Tooltip("Choose to apply the effect to the entire screen, or fade in/out over a distance")]
		public KuwaharaModeParam mode;

		public ClampedIntParameter radius;

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
		public Kuwahara()
		{

		}
	}
}
