using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/OldFilm")]
public class OldFilm //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0f, 60f)]
	[Tooltip("Frames per second.")]
	public ClampedFloatParameter fps;

	[Range(0f, 5f)]
	[Tooltip(".")]
	public ClampedFloatParameter contrast;

	[Range(-2f, 4f)]
	[Tooltip("Image burn.")]
	public ClampedFloatParameter burn;

	[Range(0f, 16f)]
	[Tooltip("Scene cut off.")]
	public ClampedFloatParameter sceneCut;

	[Range(0f, 1f)]
	[Tooltip("Effect fade.")]
	public ClampedFloatParameter fade;

	[Space]
	[Tooltip("Mask texture")]
	public TextureParameter mask;

	public maskChannelModeParameter maskChannel;

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
	public OldFilm()
	{

	}
}
