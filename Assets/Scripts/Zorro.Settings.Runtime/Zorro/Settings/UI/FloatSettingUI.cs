using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;

namespace Zorro.Settings.UI
{
	public class FloatSettingUI : SettingInputUICell
	{
		public TMP_InputField inputField;

		public Slider slider;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Setup(Setting setting, ISettingHandler settingHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FloatSettingUI()
		{

		}
	}
}
