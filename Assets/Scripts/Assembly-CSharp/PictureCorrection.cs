using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Picture Correction")]
public class PictureCorrection : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(-0.25f, 0.25f)]
	[Tooltip(" Y permanent adjustment..")]
	public ClampedFloatParameter signalAdjustY;

	[Range(-0.25f, 0.25f)]
	[Tooltip("I permanent adjustment..")]
	public ClampedFloatParameter signalAdjustI;

	[Range(-0.25f, 0.25f)]
	[Tooltip("Q permanent adjustment..")]
	public ClampedFloatParameter signalAdjustQ;

	[Range(-2f, 2f)]
	[Tooltip("tweak/shift Y values..")]
	public ClampedFloatParameter signalShiftY;

	[Range(-2f, 2f)]
	[Tooltip("tweak/shift I values..")]
	public ClampedFloatParameter signalShiftI;

	[Range(-2f, 2f)]
	[Tooltip("tweak/shift Q values..")]
	public ClampedFloatParameter signalShiftQ;

	[Range(0f, 2f)]
	[Tooltip("use this to balance the gamma(brightness) of the signal.")]
	public ClampedFloatParameter gammaCorection;

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
	public PictureCorrection()
	{
		throw null;
	}
}
