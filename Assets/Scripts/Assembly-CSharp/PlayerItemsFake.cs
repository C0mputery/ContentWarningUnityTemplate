using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerItemsFake : MonoBehaviour
{
	private Player player;

	private Bodypart itemBodypart;

	private Transform targetHandGizmo;

	private int m_displayingSlot;

	public FakeFlashLight fakeFlashLight;

	private bool once;

	public GameObject itemCopy;

	public ItemInstance CurrentItem
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
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Equip(ItemDescriptor itemDescriptor, GameObject fakeItemGo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Quaternion GetSpawnRot(Item item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 GetSpawnPos(Item item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerItemsFake()
	{

	}
}
