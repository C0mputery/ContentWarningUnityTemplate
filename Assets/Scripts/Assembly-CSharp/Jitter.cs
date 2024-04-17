using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Jitter")]
public class Jitter : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("Enable Twitch on X axes.")]
	public BoolParameter twitchHorizontal;

	[Range(0f, 5f)]
	[Tooltip("Twitch frequency on X axes.")]
	public ClampedFloatParameter horizontalFreq;

	[Space]
	[Tooltip("Enable Twitch on Y axes.")]
	public BoolParameter twitchVertical;

	[Range(0f, 5f)]
	[Tooltip("Twitch frequency on Y axes.")]
	public ClampedFloatParameter verticalFreq;

	[Space]
	[Tooltip("Enable Stretch.")]
	public BoolParameter stretch;

	[Tooltip("Stretch Resolution.")]
	public FloatParameter stretchResolution;

	[Space]
	[Tooltip("Enable Horizontal Interlacing.")]
	public BoolParameter jitterHorizontal;

	[Range(0f, 5f)]
	[Tooltip("Amount of horizontal interlacing.")]
	public ClampedFloatParameter jitterHorizontalAmount;

	[Space]
	[Tooltip("Shake Vertical.")]
	public BoolParameter jitterVertical;

	[Range(0f, 15f)]
	[Tooltip("Amount of shake.")]
	public ClampedFloatParameter jitterVerticalAmount;

	[Range(0f, 15f)]
	[Tooltip("Speed of vertical shake. ")]
	public ClampedFloatParameter jitterVerticalSpeed;

	[Space]
	[Tooltip("Time.unscaledTime .")]
	public BoolParameter unscaledTime;

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
	public Jitter()
	{
		throw null;
	}
}
