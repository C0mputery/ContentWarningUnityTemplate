using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundEffectInstance", menuName = "Landfall/SoundEffectInstance")]
public class SFX_Instance : ScriptableObject
{
	public AudioClip[] clips;

	public SFX_Settings settings;

	internal float lastTimePlayed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioClip GetClip()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Play(Vector3 pos = default(Vector3), bool local = false, float volumeMultiplier = 1f, Transform followTransform = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal float GetPitch()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal float GetVolume()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void OnPlayed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool ReadyToPlay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SFX_Instance()
	{
		throw null;
	}
}
