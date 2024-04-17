using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SFX_PlayOneShot : MonoBehaviour
{
	public Action beforePlayAction;

	public Action afterPlayAction;

	public bool playOnStart;

	public bool playOnEnable;

	public bool playOnClick;

	public float cd;

	private float lastTimePlayed;

	private bool t;

	public SFX_Instance sfx;

	public SFX_Instance[] sfxs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Play()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SFX_PlayOneShot()
	{
		throw null;
	}
}
