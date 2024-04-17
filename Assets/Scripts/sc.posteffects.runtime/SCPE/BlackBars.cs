using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Screen/Black Bars")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class BlackBars : VolumeComponent, IPostProcessComponent
	{
		public enum Direction
		{
			Horizontal = 0,
			Vertical = 1
		}

		[Serializable]
		public sealed class DirectionParam : VolumeParameter<Direction>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public DirectionParam()
			{
				throw null;
			}
		}

		public DirectionParam mode;

		[Range(0f, 1f)]
		[Tooltip("Size")]
		public ClampedFloatParameter size;

		[Range(0f, 1f)]
		[Tooltip("Max Size")]
		public ClampedFloatParameter maxSize;

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
		public BlackBars()
		{
			throw null;
		}
	}
}
