using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenu("Retro Look Pro/Custom Texture")]
public class CustomTexture : VolumeComponent, IPostProcessComponent
{
	public BoolParameter enable;

	[Tooltip("Сustom texture.")]
	public TextureParameter texture;

	[Range(0f, 1f)]
	[Tooltip("Passthrough custom texture alpha chanel.")]
	public BoolParameter alpha;

	[Range(0f, 1f)]
	[Tooltip("fade parameter.")]
	public ClampedFloatParameter fade;

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
	public CustomTexture()
	{
		throw null;
	}
}
