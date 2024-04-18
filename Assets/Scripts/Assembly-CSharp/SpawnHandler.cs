using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
	private bool m_Spawned;

	[SerializeField]
	private Transform[] m_HouseSpawns;

	[SerializeField]
	private Transform[] m_DiveBellSpawns;

	[SerializeField]
	private Transform[] m_HospitalSpawns;

	private int m_LocalSpawnIndex;

	public static SpawnHandler Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
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
	private void FindLocalSpawnIndex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindHospitalSpawns()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnLocalPlayer(Spawns state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Transform GetSpawnPoint(Spawns state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpawnHandler()
	{

	}
}
