using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Glitch1")]
public class LimitlessGlitch1 : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Header("Random Seed")]
	[Tooltip("seed x")]
	public ClampedFloatParameter x;

	[Tooltip("seed y")]
	public ClampedFloatParameter y;

	[Tooltip("seed z")]
	public ClampedFloatParameter z;

	[Space]
	[Tooltip("Effect fade.")]
	public ClampedFloatParameter fade;

	[Tooltip("Effect amount")]
	public ClampedFloatParameter amount;

	[Tooltip("Stretch on X axes")]
	public ClampedFloatParameter stretch;

	[Tooltip("Effect speed.")]
	public ClampedFloatParameter speed;

	[Space]
	[Tooltip("Red.")]
	public ClampedFloatParameter rMultiplier;

	[Tooltip("Green.")]
	public ClampedFloatParameter gMultiplier;

	[Tooltip("Blue.")]
	public ClampedFloatParameter bMultiplier;

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
	public LimitlessGlitch1()
	{
		throw null;
	}
}
