using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;
using Zorro.Settings;

public class KeyCodeSettingUI : SettingInputUICell
{
	public TextMeshProUGUI label;

	public Button button;

	private KeyCodeSetting keyCodeSetting;

	private KeybindListenHandle keybindListenHandle;

	private ISettingHandler settingHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Setup(Setting setting, ISettingHandler settingHandler)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnButtonClicked()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyCodeSettingUI()
	{
		throw null;
	}
}
