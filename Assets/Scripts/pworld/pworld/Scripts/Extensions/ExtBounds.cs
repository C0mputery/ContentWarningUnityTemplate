using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtBounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ContainsXZ(this Bounds me, Vector2 point)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2[] GetCorners(this Bounds me)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static (Vector2, Vector2) Find2ClosestCorners(this Bounds me, Vector2 point)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 GetClosestPointOnEdgeOfBounds(this Bounds me, Vector2 point)
		{
			throw null;
		}
	}
}
