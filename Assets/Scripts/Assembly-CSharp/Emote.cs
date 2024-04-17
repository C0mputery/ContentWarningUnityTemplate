using System;
using System.Runtime.CompilerServices;

[Serializable]
public class Emote
{
	public string displayName;

	public string animationName;

	public bool unequip;

	public float emoteLength;

	public float emoteMovementSpeed;

	public bool emoteAllowRotate;

	public float emoteBaseScore;

	public float emoteScoreMultiplier;

	public string[] comments;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Emote()
	{
		throw null;
	}
}
