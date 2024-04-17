using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Settings
{
	public abstract class KeyCodeSetting : IntSetting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override int GetDefaultValue()
		{
			throw null;
		}

		protected abstract KeyCode GetDefaultKey();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GameObject GetSettingUICell()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyCode Keycode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ApplyValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected KeyCodeSetting()
		{
			throw null;
		}
	}
}
