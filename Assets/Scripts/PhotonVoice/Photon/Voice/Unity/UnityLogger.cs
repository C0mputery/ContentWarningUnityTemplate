using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

namespace Photon.Voice.Unity
{
	public static class UnityLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Log(DebugLevel level, Object obj, string tag, string objName, string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetFormatString(DebugLevel level, string tag, string objName, string fmt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetTimestamp()
		{
			throw null;
		}
	}
}
