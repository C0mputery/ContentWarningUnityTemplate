using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Photon.Pun;
using UnityEngine;

namespace DefaultNamespace
{
	public class CaptchaGame : MonoBehaviour
	{
		public enum RESULT
		{
			notStarted = 0,
			playing = 1,
			completed = 2,
			failed = 3
		}

		public class Captcha
		{
			public string captcha;

			public static readonly string possibles;

			public int progress;

			public bool Complete
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string GetCaptchaString(int length)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Captcha(string captcha)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Try(char inputtedChar)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Captcha()
			{
				throw null;
			}
		}

		public int captchaLength;

		public float waitBetweenTries;

		public float timePerTry;

		public int maxTries;

		public float timeToFail;

		public RESULT gameState;

		public PhotonView view;

		[NotNull]
		public Canvas canvas;

		public Captcha currentCaptcha;

		private int fails;

		[HideInInspector]
		public CapturedCaptchaCanvas capturedCanvas;

		[HideInInspector]
		public CaptchaTerminalCanvas terminalCavnas;

		private Bot_Weeping weeping_g;

		public SFX_Instance successInputSound;

		public SFX_Instance failedInputSound;

		public int Fails
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TurnOffGame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateGame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NewCaptcha()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPCA_NewCaptcha(string captcha)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartGame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RunTimer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ValidInput(string input)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPCA_TimedOut()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Try(char inputtedChar)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CaptchaGame()
		{
			throw null;
		}
	}
}
