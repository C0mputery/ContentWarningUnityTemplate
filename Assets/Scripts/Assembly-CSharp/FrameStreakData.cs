using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(menuName = "Data/FrameStreakData", order = 9999, fileName = "FrameStreakData")]
public class FrameStreakData : SingletonAsset<FrameStreakData>
{
	public AnimationCurve streakCurve;

	public AnimationCurve seenAmountCurve;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FrameStreakData()
	{

	}
}
