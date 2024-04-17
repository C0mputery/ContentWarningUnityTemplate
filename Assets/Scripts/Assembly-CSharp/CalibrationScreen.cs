using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zorro.Core;
using Zorro.Settings.UI;

public class CalibrationScreen : RetrievableResourceSingleton<CalibrationScreen>
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CalibrationScreen _003C_003E4__this;

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
		public _003CStart_003Ed__22(int _003C_003E1__state)
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

	public GameObject voiceChatScreen;

	public GameObject calibrationScreen;

	public Action onClosed;

	public RawImage calibrationTexture;

	public GameObject voiceCell;

	public GameObject voiceModeCell;

	public VoiceSettingUICell voiceSettingUICell;

	public EnumSettingUI enumSettingsUI;

	public FloatSettingUI floatSettingUI;

	private VoiceSetting voiceSetting;

	private VoiceChatModeSetting voiceChatModeSetting;

	private BrightnessSetting brightnessSetting;

	public TextMeshProUGUI m_ThisGameUsesVoiceText;

	public TextMeshProUGUI m_UseHeadPhonesText;

	public TextMeshProUGUI m_SelectMicrophoneText;

	public TextMeshProUGUI m_SelectVoiceText;

	public TextMeshProUGUI m_AdjustBrightnessText;

	public TextMeshProUGUI m_AdjustMonsterText;

	public TextMeshProUGUI m_BrightnessText;

	public TextMeshProUGUI m_ContinueText;

	public TextMeshProUGUI m_ContinueText2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowVoiceChatScreen(Action onClosed = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CStart_003Ed__22))]
	private IEnumerator Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoToCalibrationScreen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Hide()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CalibrationScreen()
	{
		throw null;
	}
}
