using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

namespace DefaultNamespace.Artifacts
{
	public class CurseOfGravityFlip : MonoBehaviour, IArtifactCurse
	{
		public float upAmount;

		[SerializeField]
		private float rarity;

		[SerializeField]
		private float budgetCost;

		public Player cursedPlayer;

		public ItemInstanceBehaviour itemInstanceBehaviourSource;

		public Item itemSource;

		private PhotonView view_g;

		public float killTime;

		private float timeSinceLastDamage;

		public float Rarity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float BudgetCost
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CastCurse(ItemInstanceBehaviour cursedItem, Player playerHoldingItem)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPCA_AttachToPlayer(int playerid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurseOfGravityFlip()
		{

		}
	}
}
