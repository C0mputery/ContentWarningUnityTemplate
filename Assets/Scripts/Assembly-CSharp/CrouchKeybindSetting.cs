using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Settings;

public class CrouchKeybindSetting : KeyCodeSetting, IExposedSetting
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override KeyCode GetDefaultKey()
	{
		throw null;
	}

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
	public CrouchKeybindSetting()
	{

	}
}
