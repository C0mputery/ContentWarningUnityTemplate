using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Warp")]
public class Warp //: VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Range(0f, 1f)]
	[Tooltip("Dark areas adjustment.")]
	public ClampedFloatParameter fade;

	[Tooltip("Warp mode.")]
	public WarpModeParameter warpMode;

	[Tooltip("Warp image corners on x/y axes.")]
	public Vector2Parameter warp;

	[Tooltip("Warp picture center.")]
	public FloatParameter scale;

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
	public Warp()
	{

	}
}
