using System.Runtime.CompilerServices;
using DefaultNamespace;
using UnityEngine;
using Zorro.Core;

public class ExtractVideoStationHatch : MonoBehaviour, IThrowTarget
{
	public ExtractVideoMachine Machine;

	public bool m_opened;

	public float Spring;

	public float Drag;

	public float m_openedRotation;

	public float m_closedRotation;

	private bool onCooldown;

	private OneDPhysicsSpring m_spring;

	[SerializeField]
	private float m_throwImpactForce;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HitByThrowable(ItemInstance item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Close()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFullyClosed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Open()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHalfwayOpen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractVideoStationHatch()
	{

	}
}
