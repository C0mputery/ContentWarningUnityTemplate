using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Settings.DebugUI;

namespace Zorro.Settings
{
	public class ResolutionSetting : Setting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Load(ISettingsSaveLoad loader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Save(ISettingsSaveLoad saver)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ApplyValue()
		{
			throw null;
		}

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
		public void SetValue(Resolution newValue, ISettingHandler settingHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> GetChoices()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Resolution> GetResolutions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCurrentChoice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResolutionSetting()
		{

		}
	}
}
