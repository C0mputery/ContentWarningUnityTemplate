using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/VHS Effect")]
public class VHSEffect : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("Color Offset.")]
	public ClampedFloatParameter colorOffset;

	[Tooltip("Color Offset Angle.")]
	public ClampedFloatParameter colorOffsetAngle;

	[Space]
	[Tooltip("Vertical twitch frequency.")]
	public ClampedFloatParameter verticalOffsetFrequency;

	[Tooltip("Amount of vertical twitch. ")]
	public ClampedFloatParameter verticalOffset;

	[Tooltip("Amount of horizontal distortion.")]
	public ClampedFloatParameter offsetDistortion;

	[Space]
	[Tooltip("Noise texture.")]
	public TextureParameter noiseTexture;

	public BlendModeParameter blendMode;

	public Vector2Parameter tile;

	[Space]
	[Tooltip("Intensity of noise texture.")]
	public ClampedFloatParameter _textureIntensity;

	[Space]
	public BoolParameter smoothCut;

	[Tooltip("Amount of horizontal distortion.")]
	public ClampedIntParameter iterations;

	[Tooltip("Amount of horizontal distortion.")]
	public ClampedFloatParameter smoothSize;

	[Tooltip("Amount of horizontal distortion.")]
	public ClampedFloatParameter deviation;

	[Space]
	[Tooltip("Cut off.")]
	public ClampedFloatParameter _textureCutOff;

	[Space]
	[Tooltip("black bars")]
	public ClampedFloatParameter stripes;

	[Space]
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
	public VHSEffect()
	{
		throw null;
	}
}
