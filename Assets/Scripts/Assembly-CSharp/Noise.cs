using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Noise")]
public class Noise //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("stretch Resolution")]
	public FloatParameter stretchResolution;

	[Tooltip("Vertical Resolution")]
	public FloatParameter VerticalResolution;

	[Space]
	[Space]
	[Tooltip("Granularity")]
	public BoolParameter Granularity;

	[Tooltip("Granularity Amount")]
	public ClampedFloatParameter GranularityAmount;

	[Space]
	[Tooltip("Tape Noise")]
	public BoolParameter TapeNoise;

	[Tooltip("Tape Noise Signal Processing")]
	public ClampedFloatParameter TapeNoiseSignalProcessing;

	[Tooltip("Tape Noise Fade")]
	public ClampedFloatParameter TapeNoiseFade;

	[Tooltip("Tape Noise Amount(lower value = more noise)")]
	public ClampedFloatParameter TapeNoiseAmount;

	[Tooltip("tape Lines Amount")]
	public ClampedFloatParameter tapeLinesAmount;

	[Tooltip("Tape Noise Speed")]
	public ClampedFloatParameter TapeNoiseSpeed;

	[Space]
	[Tooltip("Line Noise")]
	public BoolParameter LineNoise;

	[Tooltip("Line Noise Amount")]
	public ClampedFloatParameter LineNoiseAmount;

	[Tooltip("Line Noise Speed")]
	public ClampedFloatParameter LineNoiseSpeed;

	[Space]
	[Tooltip("Signal Noise")]
	public BoolParameter SignalNoise;

	[Tooltip("Signal Noise Power")]
	public ClampedFloatParameter SignalNoisePower;

	[Tooltip("Signal Noise Amount")]
	public ClampedFloatParameter SignalNoiseAmount;

	[Space]
	[Tooltip("Mask texture")]
	public TextureParameter mask;

	public maskChannelModeParameter maskChannel;

	[Tooltip("Time.unscaledTime.")]
	public BoolParameter unscaledTime;

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
	public Noise()
	{

	}
}
