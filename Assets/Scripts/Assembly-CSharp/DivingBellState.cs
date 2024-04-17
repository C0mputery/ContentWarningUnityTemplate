using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Zorro.Core;

public abstract class DivingBellState : StateMachineState
{
	public static Color GREEN
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static Color RED
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public abstract void SetStatusText(TextMeshProUGUI statusText);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected DivingBellState()
	{
		throw null;
	}
}
