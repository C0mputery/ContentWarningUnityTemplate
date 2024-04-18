using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

namespace Zorro.Settings.DebugUI
{
	public class EnumSettingsUI : SettingUI
	{
		private EnumSetting _setting;

		private ISettingHandler _handler;

		private List<string> _choices;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnumSettingsUI(EnumSetting setting, ISettingHandler settingHandler)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Callback(ChangeEvent<string> evt)
		{
			throw null;
		}
	}
}
