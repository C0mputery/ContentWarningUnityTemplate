using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Cinematic Bars")]
public class CinematicBars //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0.5f, 0.01f)]
	[Tooltip("Black bars amount (width)")]
	public ClampedFloatParameter amount;

	[Range(0f, 1f)]
	[Tooltip("Fade black bars.")]
	public ClampedFloatParameter fade;

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
	public CinematicBars()
	{

	}
}
