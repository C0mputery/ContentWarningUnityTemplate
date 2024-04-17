using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

namespace DefaultNamespace
{
	public class Bot_Slurper : MonoBehaviour, IThrowTarget
	{
		public float targetReelLevel;

		public float reelSpeed;

		public float currentReelLevel;

		public Vector2 minMaxIdleReelTarget;

		public float cooldown;

		public Transform stickyBlob;

		public float sinceGrab;

		public float sinceGrabTimeMul;

		public float playerDrag;

		public float maxSinceGrounded;

		public float allRigMul;

		public float attachedLimbMul;

		public float pullForce;

		public Player playerAttached;

		public Rigidbody attachedLimb;

		public float maxLength;

		public float dealDamageInterval;

		public float damageAmount;

		public bool isSticky;

		private Bot bot_g;

		private Collider[] colliders;

		private Vector3 lineEndPoint;

		private LineRenderer lineRenderer_g;

		private float maxReelDistance;

		private float timeSinceDamage;

		private PhotonView view_g;

		public Material hiddenMaterial;

		public Material visibleMaterial;

		public MeshRenderer stickyBlobRenderer;

		public MeshRenderer handRenderer;

		public float itemChance;

		public SFX_Instance[] attatchSFX;

		public SFX_Instance[] detatchSFX;

		public GameObject sfxLoop;

		private bool t;

		private Vector3 targetBlobPos;

		private static float collideCount;

		public bool attackMonsters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool FindSpawnSpot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CanSpawn()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float GetNewReelTarget()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPCA_SyncStart(Vector3 pos, Vector3 lineEndPosition, float targetReel, float rotation, bool attackMonsters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		public void RPCA_ReleasePlayer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		public void RPCA_AttachBlob(int viewID, int bodyPartID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReleasePlayer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HitByThrowable(ItemInstance item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bot_Slurper()
		{
			throw null;
		}
	}
}
