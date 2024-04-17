using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zorro.Settings;

public class SettingsHandler : ISettingHandler, IDisposable
{
	private List<Setting> settings;

	private ISettingsSaveLoad _settingsSaveLoad;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SettingsHandler()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterPage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveSetting(Setting setting)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Setting> GetAllSettingsNonAlloc()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetSetting<T>() where T : Setting
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Setting> GetSettings(SettingCategory category)
	{
		throw null;
	}
}
