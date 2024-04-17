using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Pun
{
	[Serializable]
	[HelpURL("https://doc.photonengine.com/en-us/pun/v2/getting-started/initial-setup")]
	public class ServerSettings : ScriptableObject
	{
		[Tooltip("Core Photon Server/Cloud settings.")]
		public AppSettings AppSettings;

		[Tooltip("Developer build override for Best Region.")]
		public string DevRegion;

		[Tooltip("Log output by PUN.")]
		public PunLogLevel PunLogging;

		[Tooltip("Logs additional info for debugging.")]
		public bool EnableSupportLogger;

		[Tooltip("Enables apps to keep the connection without focus.")]
		public bool RunInBackground;

		[Tooltip("Simulates an online connection.\nPUN can be used as usual.")]
		public bool StartInOfflineMode;

		[Tooltip("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		public static string BestRegionSummaryInPreferences
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UseCloud(string cloudAppid, string code = "")
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAppId(string val)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResetBestRegionCodeInPreferences()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSettings()
		{
			throw null;
		}
	}
}
