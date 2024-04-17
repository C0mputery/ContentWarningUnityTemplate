using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity.UtilityScripts
{
	public class MicrophonePermission : VoiceComponent
	{
		private bool hasPermission;

		[SerializeField]
		private bool autoStart;

		public bool HasPermission
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		public static event Action<bool> MicrophonePermissionCallback
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
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitVoice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MicrophonePermission()
		{
			throw null;
		}
	}
}
