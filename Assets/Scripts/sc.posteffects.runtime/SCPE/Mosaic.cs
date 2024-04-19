using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Stylized/Mosaic")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Mosaic //: VolumeComponent, IPostProcessComponent
	{
		public enum MosaicMode
		{
			Triangles = 0,
			Hexagons = 1,
			Circles = 2
		}

		[Serializable]
		public sealed class MosaicModeParam : VolumeParameter<MosaicMode>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public MosaicModeParam()
//			{
//				throw null;
//			}
		}

		public MosaicModeParam mode;

		[Range(0f, 1f)]
		[Tooltip("Size")]
		public ClampedFloatParameter size;

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
		public Mosaic()
		{

		}
	}
}
