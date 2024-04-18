using System.Runtime.CompilerServices;
using UnityEngine;

internal class TerrainChunk
{
	public Vector2Int startID;

	public float[,] heights;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TerrainChunk()
	{

	}
}
