using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace SCPE
{
	[Serializable]
	public class EffectBaseSettings
	{
		[Flags]
		public enum CameraTypeFlags
		{
			None = 0,
			[InspectorName("Game (Base)")]
			GameBase = 1,
			[InspectorName("Game (Overlay)")]
			GameOverlay = 2,
			[InspectorName("Scene View")]
			SceneView = 4,
			[InspectorName("Preview")]
			Preview = 8,
			[InspectorName("Reflections")]
			Reflection = 0x10,
			[InspectorName("Hidden (HideFlags)")]
			Hidden = 0x20
		}

		public enum ExecutionOrder
		{
			[InspectorName("Before Unity's post processing effects")]
			BeforePostProcessing = 0,
			[InspectorName("After Unity's post processing effects")]
			AfterPostProcessing = 1
		}

		[Tooltip("Configure the effect to render either before/after Unity's built-in post processing.")]
		public ExecutionOrder executionOrder;

		[Tooltip("Effect will render, even if the camera has post-processing disabled")]
		public bool alwaysEnable;

		[Tooltip("Configure which camera types the effect is allowed to render on when using camera stacking\n\nNote that some depth-based effects will not work with camera stacking, due to how the stacking system handles the depth texture")]
		public CameraTypeFlags cameraTypes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EffectBaseSettings(bool enableInSceneView = true)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RenderPassEvent GetInjectionPoint()
		{
			throw null;
		}
	}
}
