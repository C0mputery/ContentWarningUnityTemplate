using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using Zorro.Core.CLI;

public class Player : MonoBehaviour
{
	[Serializable]
	public class PlayerInput
	{
		public Vector2 movementInput;

		public Vector2 lookInput;

		public bool sprintWasPressed;

		public bool sprintIsPressed;

		public bool clickWasPressed;

		public bool clickIsPressed;

		public bool clickWasReleased;

		public bool aimWasPressed;

		public bool aimIsPressed;

		public bool jumpWasPressed;

		public bool jumpIsPressed;

		public bool crouchWasPressed;

		public bool crouchIsPressed;

		public bool dropItemWasPressed;

		public bool dropItemIsPressed;

		public bool dropItemWasReleased;

		public bool interactWasPressed;

		public bool escapeWasPressed;

		public bool emoteWasPressed;

		public bool emoteIsPressed;

		public bool toggleCameraFlipWasPressed;

		private MouseSensitivitySetting mouseSensitivitySetting;

		private InvertedMouseSetting invertedMouseSetting;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SampeInput(PlayerData data, Player player)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ResetInput()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
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
		public AnimationCurve oxygenDisplayCurve;

		public bool tasable;

		public float simplifiedColliderHeight;

		public float simplifiedColliderRadius;

		public bool simplifiedRagdoll;

		public bool playerIsInRealm;

		public Vector3 gravityDirection;

		public Player player;

		public bool dead;

		public float sinceDied;

		public bool isGrounded;

		public float sinceGrounded;

		public float groundHeight;

		public Vector3 groundPos;

		public float sinceJump;

		public float distanceToGround;

		public float groundAngle;

		public float totalMass;

		public float headHeight;

		public Vector2 playerLookValues;

		public Vector3 movementVector;

		public Vector3 groundNormal;

		public Vector3 lookDirection;

		public Vector3 lookDirectionUp;

		public Vector3 lookDirectionRight;

		public bool isCrouching;

		public float crouchingFor;

		public float sinceCrouchSwitch;

		public bool isLocal;

		public float health;

		public static float maxHealth;

		public bool isSprinting;

		public float cameraPhysicsAmount;

		public float damageFeedback;

		public float targetHeight;

		public ItemInstance currentItem;

		public bool physicsAreReady;

		public int selectedItemSlot;

		public int nrOfGroundCols;

		public string groundTag;

		public bool groundBelow;

		public List<Bot> fearList;

		public bool carried;

		public bool hookedIntoTerminal;

		public float inputOverideAmount;

		public Vector2 overrideMovementInput;

		public float possession;

		public Vector3 lastSimplifiedPosition;

		public float remainingOxygen;

		public float maxOxygen;

		public bool usingOxygen;

		public float microphoneValue;

		public float throwCharge;

		public Quaternion rotationOvveride;

		public float rotationOvverideStr;

		public float jelloTime;

		public float fallTime;

		public float physicsCameraTime;

		public bool isInCostomizeTerminal;

		public bool isSnatched;

		public float dropItemsFor;

		public bool isHangingUpsideDown;

		public float currentStamina;

		public bool staminaDepleated;

		public float sinceSprint;

		public Bed bed;

		public float sleepAmount;

		public float triedToSleepTime;

		public bool rested;

		public bool isInDiveBell;

		public int framesSinceBotTeleport;

		public float emoteTime;

		public float cantUseItemFor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValues_Fixed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool StandingStill()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void UpdateValues()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float OxygenPercentage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float OxygenDisplayPercentage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float CameraPhysicsAmount()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PhysicsCamera()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void clampLookValues()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerData()
		{
			throw null;
		}
	}

	[Serializable]
	public class PlayerRefs
	{
		public PlayerRagdoll ragdoll;

		public PlayerAnimRefHandler animRefHandler;

		public GameObject rigRoot;

		public Animator animator;

		public Transform animatorTransform;

		public PlayerAnimationHandler animationHandler;

		public PlayerItems items;

		public Transform headPos;

		public Transform cameraPos;

		public PlayerInteraction interaction;

		public PlayerVisor visor;

		public Rig IKRig;

		public TwoBoneIKConstraint IK_Right;

		public Transform IK_Hand_R;

		public TwoBoneIKConstraint IK_Left;

		public Transform IK_Hand_L;

		public PhotonView view;

		public PlayerController controller;

		public IKRigHandler ikHandler;

		public SkinnedMeshRenderer bodyMeshRenderer;

		internal SphereCollider simpleCollider;

		public CursedPlayerBoss curses;

		public WalkieTalkiePlayer walkieTalkiePlayer;

		public PlayerEmotes emotes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerRefs()
		{
			throw null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelayDropItems_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CDelayDropItems_003Ed__34(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelayThenTalkToDead_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float f;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CDelayThenTalkToDead_003Ed__32(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CStart_003Ed__17(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public static Player localPlayer;

	public static Player observedPlayer;

	public bool ai;

	public PlayerInput input;

	public static bool justDied;

	public PlayerData data;

	public PlayerRefs refs;

	private PhotonGameLobbyHandler m_LobbyHandler;

	private float voiceNoiseCounter;

	private VoiceChatModeSetting m_VoiceChatModeSetting;

	public SFX_Instance sfx_0_Impact;

	private Coroutine toggleCollisionCor;

	private List<bool> collidersEnabled;

	private List<Collider> collidersToToggleList;

	public bool IsLocal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckOxygen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasFlashLightThatIsOn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CStart_003Ed__17))]
	private IEnumerator Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoInits()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeVoiceNoise()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasLockedInput()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasLockedMovement()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AllowInput()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void TakeDamage(float damage)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool Heal(float healAmount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void KillLocal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Die()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallRevive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_PlayerDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CDelayThenTalkToDead_003Ed__32))]
	private IEnumerator DelayThenTalkToDead(float f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_PlayerRevive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CDelayDropItems_003Ed__34))]
	private IEnumerator DelayDropItems()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 GetRelativePosition_Rig(BodypartType bodypart, Vector3 relativePosition)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 GetRelativePosition_Anim(BodypartType bodypart, Vector3 relativePosition)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 LookDirection(Vector3 direction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void MoveAllRigsInDirection(Vector3 delta)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 Center()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 TransformCenter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 CenterGroundPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetLookDirection(Vector3 vector3)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetGlobalPlayerData(out GlobalPlayerData d)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetInventory(out PlayerInventory o)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestCreatePickup(byte itemID, ItemInstanceData data, Vector3 pos, Quaternion rot, Vector3 vel, Vector3 angVel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestCreatePickup(Item item, ItemInstanceData data, Vector3 pos, Quaternion rot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_RequestCreatePickupVel(byte itemID, byte[] dataBuffer, Vector3 pos, Quaternion rot, Vector3 vel, Vector3 angVel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_RequestCreatePickup(byte itemID, byte[] dataBuffer, Vector3 pos, Quaternion rot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 HeadPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanSee(Vector3 targetPos, float validLookAngle = 70f, bool checkLineOfSight = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGetMic(float db)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetMicValueFromDecibels(float decibels)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool Ragdoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetPhysicsCamera(float seconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool HangingUpsideDown()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 GetUpDirection()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool NoControl()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallTakeDamageAndTase(float damage, float tase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_CallTakeDamageAndTase(float damage, float tase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallTakeDamageAndAddForceAndFall(float damage, Vector3 force, float fall)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_TakeDamageAndAddForce(float damage, Vector3 force, float fall)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallTakeDamageAndAddForceAndFallWithFallof(float damage, Vector3 force, float fall, Vector3 pos, float range)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_TakeDamageAndAddForceFallWithFallof(float damage, Vector3 force, float fall, Vector3 pos, float range)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WakeUp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal float Visibility()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_SelectSlot(int slotID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallMakeSound(int soundID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_MakeSound(int soundID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ToggleCollisionForSeconds(float seconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ReToggleCollision()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Teleport(Vector3 position, Vector3 forward)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Player()
	{
		throw null;
	}
}
