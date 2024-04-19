using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Stylized/Sketch")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Sketch //: VolumeComponent, IPostProcessComponent
	{
		public enum SketchProjectionMode
		{
			WorldSpace = 0,
			ScreenSpace = 1
		}

		[Serializable]
		public sealed class SketchProjectionParameter : VolumeParameter<SketchProjectionMode>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public SketchProjectionParameter()
//			{
//				throw null;
//			}
		}

		public enum SketchMode
		{
			EffectOnly = 0,
			Multiply = 1,
			Add = 2
		}

		[Serializable]
		public sealed class SketchModeParameter : VolumeParameter<SketchMode>
		{
//			[MethodImpl(MethodImplOptions.NoInlining)]
//			public SketchModeParameter()
//			{
//				throw null;
//			}
		}

		[Tooltip("The Red channel is used for darker shades, whereas the Green channel is for lighter.")]
		public TextureParameter strokeTex;

		[Space]
		[Tooltip("Choose the type of UV space being used")]
		public SketchProjectionParameter projectionMode;

		[Tooltip("Choose one of the different modes")]
		public SketchModeParameter blendMode;

		[Range(0f, 1f)]
		[Tooltip("Fades the effect in or out")]
		public ClampedFloatParameter intensity;

		public Vector2Parameter brightness;

		public ClampedFloatParameter tiling;

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
		public Sketch()
		{

		}
	}
}
