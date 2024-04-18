using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Serialization;

namespace Photon.Pun.UtilityScripts
{
	public class OnJoinedInstantiate : MonoBehaviour, IMatchmakingCallbacks
	{
		public enum SpawnSequence
		{
			Connection = 0,
			Random = 1,
			RoundRobin = 2
		}

		[HideInInspector]
		private Transform SpawnPosition;

		[HideInInspector]
		public SpawnSequence Sequence;

		[HideInInspector]
		public List<Transform> SpawnPoints;

		[Tooltip("Add a random variance to a spawn point position. GetRandomOffset() can be overridden with your own method for producing offsets.")]
		[HideInInspector]
		public bool UseRandomOffset;

		[Tooltip("Radius of the RandomOffset.")]
		[FormerlySerializedAs("PositionOffset")]
		[HideInInspector]
		public float RandomOffset;

		[Tooltip("Disables the Y axis of RandomOffset. The Y value of the spawn point will be used.")]
		[HideInInspector]
		public bool ClampY;

		[HideInInspector]
		public List<GameObject> PrefabsToInstantiate;

		[FormerlySerializedAs("autoSpawnObjects")]
		[HideInInspector]
		public bool AutoSpawnObjects;

		public Stack<GameObject> SpawnedObjects;

		protected int spawnedAsActorId;

		protected int lastUsedSpawnPointIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnJoinedRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SpawnObjects()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DespawnObjects(bool localOnly)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnFriendListUpdate(List<FriendInfo> friendList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnCreatedRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnCreateRoomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnJoinRoomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnJoinRandomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnLeftRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GetSpawnPoint(out Vector3 spawnPos, out Quaternion spawnRot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Transform GetSpawnPoint()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Vector3 GetRandomOffset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnJoinedInstantiate()
		{

		}
	}
}
