using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

namespace Zorro.Settings.DebugUI
{
	public class IntSettingUI : SettingUI
	{
		private IntSetting _setting;

		private ISettingHandler _handler;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IntSettingUI(IntSetting setting, ISettingHandler settingHandler)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Callback(ChangeEvent<int> evt)
		{
			throw null;
		}
	}
}
