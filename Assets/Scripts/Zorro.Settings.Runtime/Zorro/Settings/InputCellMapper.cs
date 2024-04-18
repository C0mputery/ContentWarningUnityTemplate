using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

namespace Zorro.Settings
{
	[CreateAssetMenu(fileName = "InputCellMapper", menuName = "Zorro/Settings/InputCellMapper")]
	public class InputCellMapper : SingletonAsset<InputCellMapper>
	{
		public GameObject EnumSettingCell;

		public GameObject FloatSettingCell;

		public GameObject ResolutionSettingCell;

		public GameObject KeyCodeSettingCell;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InputCellMapper()
		{

		}
	}
}
