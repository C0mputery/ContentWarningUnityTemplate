using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using Photon.Pun;
using UnityEngine;

public class Bot : MonoBehaviour, IHasPatrolGroup
{
	[Serializable]
	public class SyncData
	{
		public int targetPlayerId;

		public Vector3 lookDireciton;

		public Vector2 movementInput;

		public bool sprint;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SyncData()
		{
			throw null;
		}
	}

	public int jumpScareLevel;

	public bool canJumpScareFromBehind;

	public List<PatrolPoint.PatrolGroup> patrolGroups;

	public Transform centerTransform;

	public Transform groundTransform;

	public bool flashLightRequireLineOfSight;

	public int lightLevelRequired;

	public SyncData syncData;

	public int lastPlayerID;

	public Player targetPlayer;

	public Rigidbody targetBodypart;

	public float seeBodypartValue;

	public float sinceLookForTarget;

	public Vector3 navTargetPos_Set;

	public Vector3 navDestination_Read;

	public Vector3 navDirection_Read;

	public PatrolPoint lastPatrolPoint;

	internal PhotonView view;

	public int currentPlayerCheckID;

	public float suspicionValue;

	public float targetAngle;

	public float targetAngle_Nav;

	public int framesSincePatrol;

	public PatrolPoint patrolPoint;

	public float remainingNavDistance;

	public bool targetIsHiding;

	public float sinceAttack;

	public bool attacking;

	public bool aggro;

	private UniversalBotSounds botSounds;

	public List<Player> ignoredPlayers;

	public float distanceToTarget_Flat;

	public float distanceToTarget;

	public bool slowDownWhenNavigating;

	public float moveSpeedMultiplier;

	public float navigationSpeedAdjustment;

	public float sinceFlashLit;

	public float sinceFlashLit_LevelLight;

	public float sinceFlashLit_PlayerLight;

	private Action m_OnTargetChangeAction;

	public bool targetUnReachable;

	public float targetOutOfRangeFor;

	public float sinceLastSawTarget;

	public Vector3 lastNoisePos;

	public float sinceHeardNoise;

	public bool hurt;

	public Vector3 navOffset;

	public Vector3 lastGodNavPos;

	public bool busy;

	private float sinceSyncAttacking;

	public bool hasSearchPoint;

	public Vector3 searchPoint;

	public float hasBeenSearchingFor;

	public float sinceAlert;

	public int nrOfAlerts;

	internal bool alertable;

	public Bot patrolLeader;

	public Action<Vector3> teleportAction;

	public float turnVel;

	public float animMoveSpeedFactor;

	public int attackType;

	public bool hasConditionalObject;

	public GameObject conditionalObject;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoNavigationSlowing()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SpeedFactor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool BusyOrAttacking()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTransform()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateVariables()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetTargetPlayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 Center()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SearchPoint(float rotationSpeed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Alert(Vector3 alertPosition, int alerts = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Patrol(bool look = true, bool walk = true, float rotationSpeed = 3f, bool listenToNoise = true, Vector3 preferedDirection = default(Vector3), bool alertable = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void KeepDistanceHover(Vector3 pos, float distance, float sideMove)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool CanSee(Vector3 from, Vector3 to, float maxDistance, float maxAngle)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StandStill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Walk()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void WorldMoveTo(Vector3 position)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMovementWorld(Vector3 worldMove)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Investigate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void LoseTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChaseTarget(Vector3 headPosition, float targetDistance = 1.75f, float sidePrediction = 1f, bool lookForBetterTarget = true, float rotationSpeed = 3f, bool loseInterestIfUnreachable = false, bool backUpIfTooClose = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WalkAway(Vector3 walkAwayDir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IgnoreTargetFor(Player target, float ignoreFor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Back()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookAt(Vector3 position, float rotationSpeed = 3f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Look(Vector3 direction, float rotationSpeed = 3f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool CanSeeTarget(Vector3 headPosition, float angle = 110f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rigidbody SearchForTargetBodyPart(Vector3 headPosition, float maxRange = 70f, float maxAngle = 110f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnNoisePlayed(Vector3 noisePosition, float noiseRange, int alerts = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasRecentNoise()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LookForTarget(Vector3 headPosition, float maxRange = 70f, float maxAngle = 110f, float timeToSeeTarget = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Player TryToReturnTarget(Vector3 headPosition, float maxRange = 70f, float maxAngle = 110f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookForBetterTarget(Vector3 headPosition, float maxRange = 70f, float maxAngle = 110f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RotateThenMove(Vector3 dir, float rotationSpeed = 3f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetPlayer(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOnTargetChangeAction(Action a)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveTargetChangeAction(Action a)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Destroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void InvestigateCurrentTarget(Vector3 headPos, float aggroSpeed = 1f, float maxRange = 30f, float rotationSpeed = 3f, bool lookAt = true, bool searchPoint = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ValidateChase(Vector3 headPosition, float loseTargetTime = 4.5f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetSyncAttacking(bool setAttacking)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_BotSetAttacking(bool setAttacking)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void DoNothing()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PatrolPoint.PatrolGroup> GetGroup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLeader(Bot leader)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Teleport(Vector3 position)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Vector3 GroundPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AbleToAttack(float range = 4f, float minSinceAttack = 2.5f, Player playerReference = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Player GetNearbyPlayerInSight(float range, float angle)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot()
	{
		throw null;
	}
}
