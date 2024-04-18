using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Settings;
using Zorro.Settings.DebugUI;

public class VoiceSetting : Setting, IExposedSetting
{
	public string Value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SettingCategory GetSettingCategory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDisplayName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Load(ISettingsSaveLoad loader)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetDefaultValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Save(ISettingsSaveLoad saver)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ApplyValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override SettingUI GetDebugUI(ISettingHandler settingHandler)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GameObject GetSettingUICell()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetChoices()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentChoice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetValue(string device, ISettingHandler settingHandler)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceSetting()
	{

	}
}
