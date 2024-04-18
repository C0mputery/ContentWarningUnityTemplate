using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(menuName = "Zorro/Settings/GameSpecificInputCellMapper", fileName = "GameSpecificInputCellMapper")]
public class GameSpecificInputCellMapper : SingletonAsset<GameSpecificInputCellMapper>
{
	public GameObject VoiceCell;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameSpecificInputCellMapper()
	{

	}
}
