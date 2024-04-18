using System.Runtime.CompilerServices;
using UnityEngine;

public class PropHeightStamp : MonoBehaviour
{
	public float offset;

	public int blurRange;

	public LayerMask mask;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetWorld()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Texture2D CreateTexture(float[,] heights)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetBlurredHeight(float[,] heights, float heightBefore, int terrainX, int terrainY, int blurRange, bool[,] wasEdited)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetHeight(Terrain terrain, Vector2Int vector2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool PropIsGrounded(float terrainHeight, Ray ray, Collider col)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TerrainChunk GetTerrainChunk(Terrain terrain)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 TerrainIDToWorldPos(Terrain terrain, Vector2Int terrainID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2Int WorldPosToTerrainID(Terrain terrain, Vector3 min)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 GetMinPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 GetMaxPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Terrain GetTerrain()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropHeightStamp()
	{

	}
}
