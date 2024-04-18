using System;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class SimplePlayer : MonoBehaviour
{
	[Serializable]
	public class PlayerInput
	{
		public Vector2 movementInput;

		public Vector2 lookInput;

		public bool jumpWasPressed;

		public bool jumpIsPressed;

		public bool sprintIsPressed;

		public bool interactWasPressed;

		public bool interactIsPressed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerInput()
		{
			throw null;
		}
	}

	[Serializable]
	public class PlayerData
	{
		public Vector2 playerLookValues;

		public Vector3 playerLookForward;

		public Vector3 playerLookRight;

		public Vector3 playerLookUp;

		public bool isLocalPlayer;

		public Vector3 movementVector;

		public bool isGrounded;

		public float sinceGrounded;

		public float groundHeight;

		public Vector3 groundPos;

		public Vector3 groundNormal;

		public Vector3 relativeVel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerData()
		{
			throw null;
		}
	}

	[Serializable]
	public class PlayerRefs
	{
		public SimplePlayerController controller;

		public Transform head;

		public Transform cameraPoint;

		public Transform modelRoot;

		public Rigidbody rig;

		public PhotonView view;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerRefs()
		{
			throw null;
		}
	}

	public static SimplePlayer localPlayer;

	public PlayerInput input;

	public PlayerData data;

	public PlayerRefs refs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SimplePlayer()
	{

	}
}
