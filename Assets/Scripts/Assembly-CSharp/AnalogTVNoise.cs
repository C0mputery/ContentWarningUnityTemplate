using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Analog TV Noise")]
public class AnalogTVNoise //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("Option enables static noise (without movement).")]
	public BoolParameter staticNoise;

	[Tooltip("Horizontal/Vertical Noise lines.")]
	public BoolParameter Horizontal;

	[Range(0f, 1f)]
	[Tooltip("Effect Fade.")]
	public ClampedFloatParameter Fade;

	[Range(0f, 60f)]
	[Tooltip("Noise bar width.")]
	public ClampedFloatParameter barWidth;

	[Range(0f, 60f)]
	[Tooltip("Noise tiling.")]
	public Vector2Parameter tile;

	[Range(0f, 1f)]
	[Tooltip("Noise texture angle.")]
	public ClampedFloatParameter textureAngle;

	[Range(0f, 100f)]
	[Tooltip("Noise bar edges cutoff.")]
	public ClampedFloatParameter edgeCutOff;

	[Range(-1f, 1f)]
	[Tooltip("Noise cutoff.")]
	public ClampedFloatParameter CutOff;

	[Range(-10f, 10f)]
	[Tooltip("Noise bars speed.")]
	public ClampedFloatParameter barSpeed;

	[Tooltip("Noise texture.")]
	public TextureParameter texture;

	[Space]
	[Tooltip("Mask texture")]
	public TextureParameter mask;

	public maskChannelModeParameter maskChannel;

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
	public AnalogTVNoise()
	{

	}
}
