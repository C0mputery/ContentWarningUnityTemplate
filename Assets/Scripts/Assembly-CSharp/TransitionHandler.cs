using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using Zorro.Core;

public class TransitionHandler : RetrievableResourceSingleton<TransitionHandler>
{
	public AudioMixerGroup fadeMixer;

	public Image m_fadeImage;

	public AnimationCurve fadeToBlackCurve;

	private bool m_isFaded;

	private Coroutine m_Transition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AbortTransition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransitionToBlack(float addedDelay, Action onComplete, float startDelay)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOut(Action onComplete, float delay = 0f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TransitionHandler()
	{

	}
}
