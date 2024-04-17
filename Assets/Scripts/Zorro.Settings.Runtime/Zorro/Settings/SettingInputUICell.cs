using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Settings
{
	public abstract class SettingInputUICell : MonoBehaviour
	{
		public abstract void Setup(Setting setting, ISettingHandler settingHandler);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected SettingInputUICell()
		{
			throw null;
		}
	}
}
