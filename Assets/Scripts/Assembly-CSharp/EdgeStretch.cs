using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Edge Stretch")]
public class EdgeStretch : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	public BoolParameter left;

	public BoolParameter right;

	public BoolParameter top;

	public BoolParameter bottom;

	[Tooltip("Height of Noise.")]
	public ClampedFloatParameter height;

	[Space]
	[Tooltip("Stretch noise distortion.")]
	public BoolParameter distort;

	[Tooltip("Noise distortion frequency.")]
	public ClampedFloatParameter frequency;

	[Tooltip("Noise distortion amplitude.")]
	public ClampedFloatParameter amplitude;

	[Tooltip("Noise distortion speed.")]
	public ClampedFloatParameter speed;

	[Tooltip("Enable noise distortion random frequency.")]
	public BoolParameter distortRandomly;

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
	public EdgeStretch()
	{
		throw null;
	}
}
