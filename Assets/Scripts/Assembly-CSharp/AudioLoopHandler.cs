using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using Zorro.Core;

[DefaultExecutionOrder(-2000)]
public class AudioLoopHandler : Singleton<AudioLoopHandler>
{
	public GameObject m_sourcePrefab;

	public AudioMixerGroup boosted;

	public List<AudioLoop> audioLoops;

	public Dictionary<AudioLoop, AudioSource> audioSources;

	public AnimationCurve m_falloffCurve;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterAudioLoop(AudioLoop audioLoop)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterAudioLoop(AudioLoop audioLoop)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveSource(AudioLoop audioLoop)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignSource(AudioLoop audioLoop)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioLoopHandler()
	{
		throw null;
	}
}
