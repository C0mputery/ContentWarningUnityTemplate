using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_Feedback : MonoBehaviour
{
	public static UI_Feedback instance;

	public Dictionary<Graphic, Color> originalColors;

	private Coroutine dieCor;

	public Color offColor;

	public ParticleSystem healParticle;

	private Coroutine takeDamageCor;

	public Color takeDamageColor;

	public Color healColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Revive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Die()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HealFeedback()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TakeDamage(bool isHealing = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetColors()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColors(Graphic[] graphics, List<Color> cols)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColor(Graphic[] graphics, Color col)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UI_Feedback()
	{
		throw null;
	}
}
