using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using Zorro.Core;

public class AudioLoop : MonoBehaviour
{
	public AudioClip clip;

	public AudioMixerGroup mixerGroup;

	public float volume;

	public float pitch;

	public float minDistance;

	public float maxDistance;

	public float obstrability;

	public float blend;

	private Optionable<float> overrideStartTime;

	private int checkID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTime(float timeInSong)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetOverrideTime(out float f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool CheckBoost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioLoop()
	{
		throw null;
	}
}
