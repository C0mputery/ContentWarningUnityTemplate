using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Negative")]
public class Negative : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0f, 2f)]
	[Tooltip("Brightness.")]
	public ClampedFloatParameter luminosity;

	[Range(0f, 1f)]
	[Tooltip("Vignette amount.")]
	public ClampedFloatParameter vignette;

	[Range(0f, 1f)]
	[Tooltip("Contrast amount.")]
	public ClampedFloatParameter contrast;

	[Range(0f, 1f)]
	[Tooltip("Negative amount.")]
	public ClampedFloatParameter negative;

	[Space]
	[Tooltip("Mask texture")]
	public TextureParameter mask;

	public maskChannelModeParameter maskChannel;

	[Space]
	[Tooltip("Use Global Post Processing Settings to enable or disable Post Processing in scene view or via camera setup. THIS SETTING SHOULD BE TURNED OFF FOR EFFECTS, IN CASE OF USING THEM FOR SEPARATE LAYERS")]
	public BoolParameter GlobalPostProcessingSettings;

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
	public Negative()
	{

	}
}
