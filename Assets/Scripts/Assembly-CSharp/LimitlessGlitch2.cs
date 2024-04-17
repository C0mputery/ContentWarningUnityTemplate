using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Glitch2")]
public class LimitlessGlitch2 : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0f, 2f)]
	[Tooltip("Effect speed.")]
	public ClampedFloatParameter speed;

	[Range(1f, -1f)]
	[Tooltip("Effect intensity.")]
	public ClampedFloatParameter intensity;

	[Range(1f, 2f)]
	[Tooltip("block size (higher value = smaller blocks.")]
	public ClampedFloatParameter resolutionMultiplier;

	[Range(0f, 1f)]
	[Tooltip("blocks width (max value makes effect fullscreen).")]
	public ClampedFloatParameter stretchMultiplier;

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
	public LimitlessGlitch2()
	{
		throw null;
	}
}
