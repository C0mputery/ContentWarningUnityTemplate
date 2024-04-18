using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;
using Zorro.Settings;
using Zorro.Settings.DebugUI;

public class VoiceSettingDebugUI : SettingUI
{
	private VoiceSetting _setting;

	private ISettingHandler _handler;

	private List<string> _choices;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceSettingDebugUI(VoiceSetting setting, ISettingHandler settingHandler)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Callback(ChangeEvent<string> evt)
	{
		throw null;
	}
}
