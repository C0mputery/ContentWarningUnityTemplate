using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

namespace DefaultNamespace
{
	public class Bot_MimicInfiltratorSpawner : MonoBehaviour
	{
		public GameObject mimicInfiltratorPrefab;

		public Player hitTarget;

		public Player mimickingPlayer;

		public GameObject spawnedInfiltrator;

		private Bot_MimicInfiltrator botMimicInfiltrator;

		private PhotonView view;

		private float timeSinceStart;

		private bool waitingToSpawn;

		public bool Infiltrating
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
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DebugSpawn()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bot_MimicInfiltratorSpawner()
		{

		}
	}
}
