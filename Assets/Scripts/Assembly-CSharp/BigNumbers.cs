using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using Zorro.Core;

[CreateAssetMenu(fileName = "BigNumbers", menuName = "BigNumbers")]
public class BigNumbers : SingletonAsset<BigNumbers>
{
	[Header("Rounds")]
	public AnimationCurve scoreRequiredPerWeek;

	public AnimationCurve scoreToViewConversionPerRun;

	public AnimationCurve ScoreToMoneyPerWeek;

	public int StartMoney;

	public int MoneyPerRound;

	[Header("Monsters")]
	public float BarnacleBallScore;

	public float BigSlapAgro;

	public float BigSlapPeaceful;

	public float EarScore;

	public float FlickerScore;

	public float JelloScore;

	public float KnifoScore;

	public float bombsScore;

	public float spiderScore;

	public float larvaScore;

	public float dogScore;

	public float camCreepScore;

	public float eyeGuyScore;

	public float MouthScore;

	public float SlurperScore;

	public float SnatchoScore;

	public float ToolkitWhiskScore;

	public float WeepingScoreIdle;

	public float WeepingScoreSuccuess;

	public float WeepingScoreFail;

	public float WeepingScoreCaptured;

	public float ZombieScore;

	[Header("Players")]
	public float PlayerScore;

	public float playerRagdollScore;

	public float playerSmallFallScore;

	public float playerBigFallScore;

	public float playerDeadScore;

	public float PlayerFacingAwayFactor;

	public float PlayerFacingTowardsFactor;

	public float PlayerMicrophoneBounus;

	[Header("Camera")]
	public AnimationCurve streakCurve;

	public AnimationCurve percentageToScreenToFactorCurve;

	public int MaxSameEventType;

	[Header("Monster Budget")]
	public AnimationCurve monsterBudgetPerDay;

	public int day1ExtraMoBudget;

	public int day2ExtraMoBudget;

	public int day3ExtraMoBudget;

	public Vector2 minMaxSecoundRoundSpawnTime;

	public Vector2 firstSpawnAmount;

	[FormerlySerializedAs("biggestPurchasePerDay")]
	public AnimationCurve biggestMonsterPurchasePerDay;

	[Header("Artifact")]
	public AnimationCurve artifactBudgetPerDay;

	public AnimationCurve rarestArtifactPerDay;

	[Header("ToolSpawner")]
	public AnimationCurve toolBudgetPerDay;

	public AnimationCurve rarestToolPerDay;

	public Vector2Int toolPerDayAddMinMax;

	private float firstWaveSizeWas;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetTempDiveBellDifficulty(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDiveBellDifficultyHarbour(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetGiveDiveBellDifficultyFactory(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ViewsToString(int numberIn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetScoreToViews(float score, int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetScoreToViewsFromRun(float score, int run)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetSecondWaveWaitTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetMoneyFromScore(float score, int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetMoneyFromScoreByRun(float score, int run)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetQuota(int runIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetMonsterBudgetForDayFirstWave(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetMonsterBudgetForSecondWave(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetBiggestMonsterPurchaseForDay(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetArtifactBudgetForDay(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetRarestArtifactForDay(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetToolBudgetForDay(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetRarestToolForDay(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetExtraBudgetForDay(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BigNumbers()
	{
		throw null;
	}
}
