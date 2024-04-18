using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

namespace Zorro.Settings.DebugUI
{
	public class FloatSettingUI : SettingUI
	{
		private FloatSetting _setting;

		private ISettingHandler _handler;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FloatSettingUI(FloatSetting setting, ISettingHandler settingHandler)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Callback(ChangeEvent<float> evt)
		{
			throw null;
		}
	}
}
