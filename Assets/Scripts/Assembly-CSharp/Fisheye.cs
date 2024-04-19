using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Fisheye")]
public class Fisheye //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	public FisheyeTypeParameter fisheyeType;

	[Range(0f, 50f)]
	[Tooltip("Bend Amount.")]
	public ClampedFloatParameter bend;

	[Range(0f, 50f)]
	[Tooltip("Cutoff on X axes.")]
	public ClampedFloatParameter cutOffX;

	[Range(0f, 50f)]
	[Tooltip("Cutoff on Y axes.")]
	public ClampedFloatParameter cutOffY;

	[Range(0f, 50f)]
	[Tooltip("Fade on X axes.")]
	public ClampedFloatParameter fadeX;

	[Range(0f, 50f)]
	[Tooltip("Fade on Y axes.")]
	public ClampedFloatParameter fadeY;

	[Range(0.001f, 50f)]
	[Tooltip("Fisheye size.")]
	public ClampedFloatParameter size;

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
	public Fisheye()
	{

	}
}
