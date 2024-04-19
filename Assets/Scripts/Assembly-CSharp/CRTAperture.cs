using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/CRT Aperture")]
public class CRTAperture //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("Glow Halation.")]
	public ClampedFloatParameter GlowHalation;

	[Tooltip("Glow Difusion.")]
	public ClampedFloatParameter GlowDifusion;

	[Tooltip("Mask Colors.")]
	public ClampedFloatParameter MaskColors;

	[Tooltip("Mask Strength.")]
	public ClampedFloatParameter MaskStrength;

	[Tooltip("Gamma Input.")]
	public ClampedFloatParameter GammaInput;

	[Tooltip("Gamma Output.")]
	public ClampedFloatParameter GammaOutput;

	[Tooltip("Brightness.")]
	public ClampedFloatParameter Brightness;

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
	public CRTAperture()
	{

	}
}
