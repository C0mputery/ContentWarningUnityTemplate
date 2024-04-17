using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtTerrain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 PGetHeight(this Terrain me, Vector3 worldPos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 PGet01Coordinate(this Terrain me, Vector3 worldPos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 PGetNormal(this Terrain me, Vector3 worldPos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color PGetAlphamapColorAtWorldPos(this Terrain me, int numAlphaTexture, Vector3 worldPos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 PGetEdge(this Terrain me, Vector3 worldPos, bool right = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3[] PGetCorners(this Terrain t)
		{
			throw null;
		}
	}
}
