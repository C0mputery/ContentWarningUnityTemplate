using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Retro/Pixelize")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class Pixelize : VolumeComponent, IPostProcessComponent
	{
		public enum Resolution
		{
			Custom = 1,
			[InspectorName("600p")]
			Sixhundred = 600,
			[InspectorName("480p")]
			FourEighty = 480,
			[InspectorName("240p")]
			TwoFourty = 240,
			[InspectorName("200p")]
			TwoHundred = 200,
			[InspectorName("160p")]
			HundredSixty = 160
		}

		[Serializable]
		public sealed class ResolutionPreset : VolumeParameter<Resolution>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResolutionPreset()
			{
				throw null;
			}
		}

		public ClampedFloatParameter amount;

		public IntParameter resolution;

		public ResolutionPreset resolutionPreset;

		[Tooltip("When disabled, pixels will retain a square aspect ratio")]
		public BoolParameter preserveAspectRatio;

		[Tooltip("When enabled, pixels are shifted by half. Mostly has a visible effect on extremely low resolutions")]
		public BoolParameter centerPixel;

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
		public Pixelize()
		{
			throw null;
		}
	}
}
