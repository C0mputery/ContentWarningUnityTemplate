using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class BedBoss : MonoBehaviour
{
	[Serializable]
	public class Bed
	{
		public BedBoss bedBoss;

		public MeshRenderer duveMeRe;

		public GameObject go;

		public int currentMaterialIndex;

		private Player sleepingPlayer;

		public bool IsClaimed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bed(BedBoss bedboss, GameObject go)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPlayerLeft(Player player)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPlayer(Player player)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}
	}

	public Material[] materials;

	public List<Bed> beds;

	public Material[] unusedBedMaterials;

	public bool dontApply;

	private PhotonView view_g;

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
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPlayerJoined(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void AssignBed(int viewId, int siblingId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedBoss()
	{

	}
}
