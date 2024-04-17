using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtMath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PClampToSizeOf<T>(this int value, List<T> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PClampToSizeOf<T>(this int value, IEnumerable<T> array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PClampToSizeOf<T>(this int value, T[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsBetween(this float me, float min, float max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsEven(this int me)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NearlyEqual(float a, float b, float epsilon = float.Epsilon)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int RandFlip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 NearestPointOnLineDir(Vector2 linePnt, Vector2 lineDir, Vector2 pnt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 NearestPointOnLineSegment(Vector2 origin, Vector2 end, Vector2 point)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float Eerp(float a, float b, float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float InverseEerp(float a, float b, float v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color LinearToGamma(Color color)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float Step(float x, float y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 Clamp(this Vector3 me, Vector3 min, Vector3 max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 Clamp(this Vector2 me, Vector2 min, Vector2 max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 GetRotationDelta(Vector3 ownForward, Vector3 targetForward)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float PLoop(float value, float min, float max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AreLinesIntersecting(Vector2 l1_p1, Vector2 l1_p2, Vector2 l2_p1, Vector2 l2_p2, bool shouldIncludeEndPoints)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FindIntersection(Vector2 line1Start, Vector2 line1End, Vector2 line2start, Vector2 line2End, out bool lines_intersect, out bool segments_intersect, out Vector2 intersection, out Vector2 close_p1, out Vector2 close_p2)
		{
			throw null;
		}
	}
}
