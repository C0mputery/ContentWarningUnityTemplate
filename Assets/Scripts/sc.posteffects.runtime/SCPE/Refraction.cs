using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Screen/Refraction")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Refraction //: VolumeComponent, IPostProcessComponent
	{
		[FormerlySerializedAs("refractionTex")]
		[Tooltip("Takes a normal map to perturb the image")]
		public TextureParameter normalMap;

		[Range(0f, 1f)]
		[Tooltip("Amount")]
		public ClampedFloatParameter amount;

		public ColorParameter tint;

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
		public Refraction()
		{

		}
	}
}
