using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using Zorro.Core;

namespace Zorro.Settings.DebugUI
{
	[CreateAssetMenu(menuName = "Zorro/Settings/SettingUxmls", fileName = "SettingUxmls")]
	public class SettingUxmls : SingletonAsset<SettingUxmls>
	{
		public VisualTreeAsset IntSettingUxml;

		public VisualTreeAsset FloatSettingUxml;

		public VisualTreeAsset EnumSettingUxml;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SettingUxmls()
		{

		}
	}
}
