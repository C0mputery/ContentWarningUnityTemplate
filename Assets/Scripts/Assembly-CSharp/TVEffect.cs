using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/TV Effect")]
public class TVEffect : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0f, 1f)]
	[Tooltip("Effect fade.")]
	public ClampedFloatParameter fade;

	[Range(0f, 2f)]
	[Tooltip("Dark areas adjustment.")]
	public ClampedFloatParameter maskDark;

	[Range(0f, 2f)]
	[Tooltip("Light areas adjustment.")]
	public ClampedFloatParameter maskLight;

	[Range(-8f, -16f)]
	[Tooltip("Dark areas fine tune.")]
	public ClampedFloatParameter hardScan;

	[Space]
	[Range(1f, 16f)]
	[Tooltip("Effect resolution.")]
	public ClampedFloatParameter resScale;

	[Tooltip("Correct effect resolution, depending on screen resolution")]
	public BoolParameter ScaleWithActualScreenSize;

	[Space]
	[Range(-3f, 1f)]
	[Tooltip("pixels sharpness.")]
	public ClampedFloatParameter hardPix;

	[Tooltip("Warp mode.")]
	public WarpModeParameter warpMode;

	[Tooltip("Warp picture.")]
	public Vector2Parameter warp;

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
	public TVEffect()
	{
		throw null;
	}
}
