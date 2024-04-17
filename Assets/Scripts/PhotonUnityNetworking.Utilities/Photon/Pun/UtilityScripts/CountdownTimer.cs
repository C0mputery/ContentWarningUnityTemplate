using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityEngine.UI;

namespace Photon.Pun.UtilityScripts
{
	public class CountdownTimer : MonoBehaviourPunCallbacks
	{
		public delegate void CountdownTimerHasExpired();

		public const string CountdownStartTime = "StartTime";

		[Header("Countdown time in seconds")]
		public float Countdown;

		private bool isTimerRunning;

		private int startTime;

		[Header("Reference to a Text component for visualizing the countdown")]
		public Text Text;

		public static event CountdownTimerHasExpired OnCountdownTimerHasExpired
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTimerRuns()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTimerEnds()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float TimeRemaining()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryGetStartTime(out int startTimestamp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetStartTime()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CountdownTimer()
		{
			throw null;
		}
	}
}
