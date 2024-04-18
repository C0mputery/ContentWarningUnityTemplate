using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

public class CDRom : Interactable
{
	public GameObject m_CD;

	public bool m_opened;

	public float Spring;

	public float Drag;

	public float m_openedPos;

	public float m_closedPos;

	private OneDPhysicsSpring m_spring;

	private Vector3 m_localPos;

	public bool hasCD;

	public ExtractVideoMachine Machine;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsValid(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
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
	public void Open()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Close()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRom(Optionable<VideoHandle> cd)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CDRom()
	{

	}
}
