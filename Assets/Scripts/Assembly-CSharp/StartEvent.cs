using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class StartEvent : MonoBehaviour
{
	public UnityEvent awakeEvent;

	public UnityEvent startEvent;

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
	public StartEvent()
	{

	}
}
