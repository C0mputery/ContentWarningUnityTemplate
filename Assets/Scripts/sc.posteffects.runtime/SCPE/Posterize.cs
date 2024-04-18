using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Retro/Posterize")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Posterize : VolumeComponent, IPostProcessComponent
	{
		public BoolParameter hsvMode;

		[Range(0f, 256f)]
		public ClampedIntParameter levels;

		[Header("Levels")]
		[Range(2f, 256f)]
		public ClampedIntParameter hue;

		[Range(2f, 256f)]
		public ClampedIntParameter saturation;

		[Range(2f, 256f)]
		public ClampedIntParameter value;

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
		public Posterize()
		{

		}
	}
}
