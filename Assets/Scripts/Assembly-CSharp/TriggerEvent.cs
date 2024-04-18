using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
	public UnityEvent triggerEvent_Enter;

	public UnityEvent triggerEvent_Exit;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerExit(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TriggerEvent()
	{

	}
}
