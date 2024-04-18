using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Realtime
{
	public class ConnectionHandler : MonoBehaviour
	{
		public bool DisconnectAfterKeepAlive;

		public int KeepAliveInBackground;

		public bool ApplyDontDestroyOnLoad;

		[NonSerialized]
		public static bool AppQuits;

		[NonSerialized]
		public static bool AppPause;

		[NonSerialized]
		public static bool AppPauseRecent;

		[NonSerialized]
		public static bool AppOutOfFocus;

		[NonSerialized]
		public static bool AppOutOfFocusRecent;

		private byte fallbackThreadId;

		private bool didSendAcks;

		private readonly Stopwatch backgroundStopwatch;

		public LoadBalancingClient Client
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public int CountSendAcksOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public bool FallbackThreadRunning
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnApplicationQuit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnApplicationPause(bool pause)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetAppPauseRecent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnApplicationFocus(bool focus)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetAppOutOfFocusRecent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsNetworkReachableUnity()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFallbackSendAckThread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopFallbackSendAckThread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RealtimeFallbackThread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectionHandler()
		{

		}
	}
}
