using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

namespace Zorro.Settings.DebugUI
{
	public class ResolutionSettingUI : SettingUI
	{
		private ResolutionSetting _setting;

		private ISettingHandler _handler;

		private List<string> _choices;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResolutionSettingUI(ResolutionSetting setting, ISettingHandler settingHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Callback(ChangeEvent<string> evt)
		{
			throw null;
		}
	}
}
