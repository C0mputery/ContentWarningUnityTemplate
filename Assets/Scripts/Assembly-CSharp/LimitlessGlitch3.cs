using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Glitch3")]
public class LimitlessGlitch3 : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0f, 50f)]
	[Tooltip("Effect speed.")]
	public ClampedFloatParameter speed;

	[Range(0f, 505f)]
	[Tooltip("block size (higher value = smaller blocks).")]
	public ClampedFloatParameter blockSize;

	[Range(0f, 25f)]
	[Tooltip("maximum color shift on X axis.")]
	public ClampedFloatParameter maxOffsetX;

	[Range(0f, 25f)]
	[Tooltip("maximum color shift on Y axis.")]
	public ClampedFloatParameter maxOffsetY;

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
	public LimitlessGlitch3()
	{
		throw null;
	}
}
