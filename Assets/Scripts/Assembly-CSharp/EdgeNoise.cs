using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Edge Noise")]
public class EdgeNoise : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	public BoolParameter left;

	public BoolParameter right;

	public BoolParameter top;

	public BoolParameter bottom;

	[Range(0.01f, 0.5f)]
	[Tooltip("Noise Height.")]
	public ClampedFloatParameter height;

	[Tooltip("Noise tiling.")]
	public Vector2Parameter tile;

	[Range(0f, 3f)]
	[Tooltip("Noise intensity.")]
	public ClampedFloatParameter intencity;

	public TextureParameter noiseTexture;

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
	public EdgeNoise()
	{
		throw null;
	}
}
