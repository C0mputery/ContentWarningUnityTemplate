using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

public class CapturedCaptchaCanvas : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFailScreen_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CapturedCaptchaCanvas _003C_003E4__this;

		public bool shake;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CFailScreen_003Ed__14(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public GameObject beforePlayerInTerminal;

	public TextMeshProUGUI beforeTimer;

	public GameObject afterPlayerInTerminal;

	public ProceduralImage gameTimer;

	public TextMeshProUGUI triesText;

	public GameObject triesRoot;

	private GameObject tryDot;

	public Color trySuccessColor;

	private Color tryDefaultColor;

	public GameObject root;

	public GameObject playingGo;

	public GameObject failureGo;

	public float showFailureTimeForTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CFailScreen_003Ed__14))]
	private IEnumerator FailScreen(bool shake)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoFailStuff(bool shake)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GameWaitingToStart(float timeToStart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GameStarted(int captchaLength)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProgress(int progress)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBeforeTimeLeft(float timeLeft)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGameTimer(float timeLeft, float maxTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTries(int fails, float maxTries)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CapturedCaptchaCanvas()
	{
		throw null;
	}
}
