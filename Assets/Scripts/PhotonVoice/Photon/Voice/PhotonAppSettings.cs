using System;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Voice
{
	[Serializable]
	public class PhotonAppSettings : ScriptableObject
	{
		[Tooltip("Core Photon Server/Cloud settings.")]
		public AppSettings AppSettings;

		private static PhotonAppSettings instance;

		private const string SettingsFileName = "VoiceAppSettings";

		private const string PhotonVoiceFolderGUID = "d3a9df3027b4a45679a2a3e978dde78e";

		public static PhotonAppSettings Instance
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
		public static void LoadOrCreateSettings()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonAppSettings()
		{

		}
	}
}
