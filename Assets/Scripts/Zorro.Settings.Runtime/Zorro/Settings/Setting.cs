using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Settings.DebugUI;

namespace Zorro.Settings
{
	public abstract class Setting : IDisposable
	{
		public abstract void Load(ISettingsSaveLoad loader);

		public abstract void Save(ISettingsSaveLoad saver);

		public abstract void ApplyValue();

		public abstract SettingUI GetDebugUI(ISettingHandler settingHandler);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		public abstract GameObject GetSettingUICell();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Setting()
		{
			throw null;
		}
	}
}
