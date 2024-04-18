using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Colormap Palette")]
public class ColormapPalette : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	public IntParameter pixelSize;

	[Range(0f, 1f)]
	[Tooltip("Opacity.")]
	public ClampedFloatParameter opacity;

	[Range(0f, 1f)]
	[Tooltip("Dithering effect.")]
	public ClampedFloatParameter dither;

	public preLParameter presetsList;

	public IntParameter presetIndex;

	[Tooltip("Dither texture.")]
	public TextureParameter bluenoise;

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
	public ColormapPalette()
	{

	}
}
