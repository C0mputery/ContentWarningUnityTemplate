using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Settings.DebugUI;

namespace Zorro.Settings
{
	public abstract class EnumSetting : IntSetting
	{
		public abstract List<string> GetChoices();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override SettingUI GetDebugUI(ISettingHandler settingHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GameObject GetSettingUICell()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected EnumSetting()
		{
			throw null;
		}
	}
}
