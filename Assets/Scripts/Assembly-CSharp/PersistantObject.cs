using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class PersistantObject : MonoBehaviour
{
	[SerializeField]
	private Item m_ItemToSwitch;

	[CanBeNull]
	public Item ItemSwitch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PersistantObject()
	{

	}
}
