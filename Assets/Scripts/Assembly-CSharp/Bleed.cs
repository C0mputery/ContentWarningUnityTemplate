using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Bleed")]
public class Bleed //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("NTSC Bleed modes.")]
	public bleedModeParameter bleedMode;

	[Tooltip("Bleed Stretch amount.")]
	public FloatParameter bleedAmount;

	[Tooltip("Debug bleed curve.")]
	public BoolParameter bleedDebug;

	[Space]
	[Tooltip("Mask texture")]
	public TextureParameter mask;

	public maskChannelModeParameter maskChannel;

	[Space]
	[Tooltip("Use Global Post Processing Settings to enable or disable Post Processing in scene view or via camera setup. THIS SETTING SHOULD BE TURNED OFF FOR EFFECTS, IN CASE OF USING THEM FOR SEPARATE LAYERS")]
	public BoolParameter GlobalPostProcessingSettings;

	public int bleedModeIndex;

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
	public Bleed()
	{

	}
}
