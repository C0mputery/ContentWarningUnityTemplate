using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	public static class UnityMicrophone
	{
		public static string[] devices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void End(string deviceName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetPosition(string deviceName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsRecording(string deviceName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string CheckDevice(ILogger logger, string logPref, string device, int suggestedFrequency, out int frequency)
		{
			throw null;
		}
	}
}
