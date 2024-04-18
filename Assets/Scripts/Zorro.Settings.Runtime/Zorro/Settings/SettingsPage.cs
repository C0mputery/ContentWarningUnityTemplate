using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zorro.Core.CLI;

namespace Zorro.Settings
{
	public class SettingsPage : DebugPage
	{
		private List<Setting> m_settings;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SettingsPage(List<Setting> settings, ISettingHandler settingHandler)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawSettings(Setting setting, ISettingHandler settingHandler)
		{
			throw null;
		}
	}
}
