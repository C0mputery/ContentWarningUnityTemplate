using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using Zorro.Core;

[CreateAssetMenu(menuName = "Zorro/MixerHolder", fileName = "MixerHolder")]
public class MixerHolder : SingletonAsset<MixerHolder>
{
	public AudioMixerGroup masterMixer;

	public AudioMixerGroup sfxMixer;

	public AudioMixerGroup voiceMixer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MixerHolder()
	{
		throw null;
	}
}
