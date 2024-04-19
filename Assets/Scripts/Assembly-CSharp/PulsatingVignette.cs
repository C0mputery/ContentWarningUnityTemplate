using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Pulsating Vignette")]
public class PulsatingVignette //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0.001f, 50f)]
	[Tooltip("Vignette shake speed.")]
	public ClampedFloatParameter speed;

	[Range(0.001f, 50f)]
	[Tooltip("Vignette amount.")]
	public ClampedFloatParameter amount;

	[Space]
	[Tooltip("Use Global Post Processing Settings to enable or disable Post Processing in scene view or via camera setup. THIS SETTING SHOULD BE TURNED OFF FOR EFFECTS, IN CASE OF USING THEM FOR SEPARATE LAYERS")]
	public BoolParameter GlobalPostProcessingSettings;

//	[MethodImpl(MethodImplOptions.NoInlining)]
//	public bool IsActive()
//	{
//		throw null;
//	}

//	[MethodImpl(MethodImplOptions.NoInlining)]
//	public bool IsTileCompatible()
//	{
//		throw null;
//	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PulsatingVignette()
	{

	}
}
