using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	[VolumeComponentMenu("SC Post Effects/Stylized/Edge Detection")]
	[SupportedOnRenderPipeline(new Type[] { typeof(UniversalRenderPipelineAsset) })]
	public sealed class EdgeDetection : VolumeComponent, IPostProcessComponent
	{
		public enum EdgeDetectMode
		{
			DepthNormals = 0,
			CrossDepthNormals = 1,
			SobelDepth = 2,
			LuminanceBased = 3
		}

		[Serializable]
		public sealed class EdgeDetectionMode : VolumeParameter<EdgeDetectMode>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public EdgeDetectionMode()
			{
				throw null;
			}
		}

		[Range(0f, 1f)]
		[Tooltip("Shows only the effect, to allow for finetuning")]
		public BoolParameter debug;

		[Space]
		[Tooltip("Choose one of the different edge solvers")]
		public EdgeDetectionMode mode;

		public BoolParameter invertFadeDistance;

		[Tooltip("Fades out the effect between the cameras near and far clipping plane")]
		public BoolParameter distanceFade;

		public FloatParameter startFadeDistance;

		public FloatParameter endFadeDistance;

		[Header("Sensitivity")]
		[InspectorName("Depth")]
		[Range(0f, 1f)]
		[Tooltip("Sets how much difference in depth between pixels contribute to drawing an edge")]
		public ClampedFloatParameter sensitivityDepth;

		[InspectorName("Normals")]
		[Range(0f, 1f)]
		[Tooltip("Sets how much difference in normals between pixels contribute to drawing an edge")]
		public ClampedFloatParameter sensitivityNormals;

		[Range(0.01f, 1f)]
		[InspectorName("Luminance Threshold")]
		[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
		public ClampedFloatParameter lumThreshold;

		[Header("Edges")]
		[InspectorName("Color")]
		[Tooltip("")]
		public ColorParameter edgeColor;

		[Range(1f, 50f)]
		[Tooltip("Edge Exponent")]
		public ClampedFloatParameter edgeExp;

		[InspectorName("Size")]
		[Range(1f, 4f)]
		[Tooltip("Edge Distance")]
		public ClampedIntParameter edgeSize;

		[InspectorName("Opacity")]
		[Tooltip("Opacity")]
		public ClampedFloatParameter edgeOpacity;

		[InspectorName("Thin")]
		[Tooltip("Limit the effect to inward edges only")]
		public BoolParameter sobelThin;

		[SerializeField]
		public Shader DepthNormalsShader;

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
		public EdgeDetection()
		{
			throw null;
		}
	}
}
