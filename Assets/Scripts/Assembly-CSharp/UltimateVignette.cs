using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Ultimate Vignette")]
public class UltimateVignette : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	public VignetteModeParameter vignetteShape;

	[Tooltip(".")]
	public Vector2Parameter center;

	[Range(0f, 100f)]
	[Tooltip(".")]
	public ClampedFloatParameter vignetteAmount;

	[Range(-1f, -100f)]
	[Tooltip(".")]
	public ClampedFloatParameter vignetteFineTune;

	[Range(0f, 100f)]
	[Tooltip("Scanlines width.")]
	public ClampedFloatParameter edgeSoftness;

	[Range(200f, 0f)]
	[Tooltip("Horizontal/Vertical scanlines.")]
	public ClampedFloatParameter edgeBlend;

	[Range(0f, 200f)]
	[Tooltip(".")]
	public ClampedFloatParameter innerColorAlpha;

	public ColorParameter innerColor;

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
	public UltimateVignette()
	{

	}
}
