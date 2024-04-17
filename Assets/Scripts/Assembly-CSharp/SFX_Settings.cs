using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

[Serializable]
public class SFX_Settings
{
	public bool spatialize;

	public bool nonSpatializedForLocalPlayer;

	public bool occlusion;

	[FormerlySerializedAs("reflection")]
	public bool reflections;

	public bool transmission;

	[Range(0f, 1f)]
	public float volume;

	[Range(0f, 1f)]
	[Tooltip("0.2 variation means random between 80% of specified volume and 100% of specified volume")]
	public float volume_Variation;

	public float pitch;

	[Range(0f, 1f)]
	[Tooltip("0.1 variation means random between 95% of specified volume and 105% of specified volume")]
	public float pitch_Variation;

	[Range(0f, 1f)]
	public float spatialBlend;

	[Range(0f, 1f)]
	public float obstructability;

	[Range(0f, 1f)]
	public float dopplerLevel;

	public float range;

	public float minRange;

	public int noiseDistance;

	public float cooldown;

	public int maxInstances;

	public AudioMixerGroup mixerGroup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SFX_Settings()
	{
		throw null;
	}
}
