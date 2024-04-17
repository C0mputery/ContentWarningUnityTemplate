using System.Runtime.CompilerServices;
using Zorro.Settings.DebugUI;

namespace Zorro.Settings
{
	public abstract class IntSetting : Setting
	{
		public int Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

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

		protected abstract int GetDefaultValue();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override SettingUI GetDebugUI(ISettingHandler settingHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetValue(int newValue, ISettingHandler settingHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected IntSetting()
		{
			throw null;
		}
	}
}
