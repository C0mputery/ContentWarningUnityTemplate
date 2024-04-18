using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

public class SettingsMenu : Singleton<SettingsMenu>
{
	public CW_TAB firstTab;

	public CW_TABS categoryTabs;

	public Transform m_settingsContainer;

	public GameObject m_settingsCell;

	private List<SettingsCell> m_cells;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Show(SettingCategory category)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectCategory(SettingCategory settingCategory)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SettingsMenu()
	{

	}
}
