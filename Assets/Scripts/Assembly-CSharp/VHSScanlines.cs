using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/VHS Scanlines")]
public class VHSScanlines : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("Lines color.")]
	public ColorParameter scanLinesColor;

	[Tooltip("Amount of scanlines.")]
	public FloatParameter scanLines;

	[Tooltip("Lines speed.")]
	public FloatParameter speed;

	[Tooltip("Effect fade.")]
	public ClampedFloatParameter fade;

	[Tooltip("Enable horizontal lines.")]
	public BoolParameter horizontal;

	[Tooltip("distortion.")]
	public ClampedFloatParameter distortion;

	[Tooltip("distortion1.")]
	public FloatParameter distortion1;

	[Tooltip("distortion2.")]
	public FloatParameter distortion2;

	[Tooltip("Scale lines size.")]
	public FloatParameter scale;

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
	public VHSScanlines()
	{

	}
}
