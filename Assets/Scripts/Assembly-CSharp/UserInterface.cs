using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using Zorro.Core;

public class UserInterface : Singleton<UserInterface>
{
	public MoneyAddedUI moneyAddedUI;

	public EquippedUI equippedUI;

	public InteractionUI interactionUI;

	public HotbarUI hotbarUI;

	public NextStepUI nextStepUI;

	public float force;

	public float movementForce;

	[FormerlySerializedAs("translationtForce")]
	public float translationForce;

	public float damp;

	public float m_maxPivotMovement;

	public Transform m_pivot;

	private Vector3 m_velocity;

	private int2 m_currentResolution;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadAspectRatio(AspectRatio aspectRatio)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowMoneyNotification(string header, string money, bool good)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserInterface()
	{

	}
}
