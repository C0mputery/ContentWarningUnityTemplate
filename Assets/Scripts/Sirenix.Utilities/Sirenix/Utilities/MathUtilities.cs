using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Utilities
{
	public static class MathUtilities
	{
		private const float ZERO_TOLERANCE = 1E-06f;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float PointDistanceToLine(Vector3 point, Vector3 a, Vector3 b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float Hermite(float start, float end, float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float StackHermite(float start, float end, float t, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float Fract(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 Fract(Vector2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 Fract(Vector3 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float BounceEaseInFastOut(float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float Hermite01(float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float StackHermite01(float t, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float amount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 LerpUnclamped(Vector2 from, Vector2 to, float amount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float Bounce(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float EaseInElastic(float value, float amplitude = 0.25f, float length = 0.6f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 Pow(this Vector3 v, float p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 Abs(this Vector3 v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 Sign(this Vector3 v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float EaseOutElastic(float value, float amplitude = 0.25f, float length = 0.6f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float EaseInOut(float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 Clamp(this Vector3 value, Vector3 min, Vector3 max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 Clamp(this Vector2 value, Vector2 min, Vector2 max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ComputeByteArrayHash(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 InterpolatePoints(Vector3[] path, float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LineIntersectsLine(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2, out Vector2 intersection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 InfiniteLineIntersect(Vector2 ps1, Vector2 pe1, Vector2 ps2, Vector2 pe2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float LineDistToPlane(Vector3 planeOrigin, Vector3 planeNormal, Vector3 lineOrigin, Vector3 lineDirectionNormalized)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float RayDistToPlane(Ray ray, Plane plane)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 RotatePoint(Vector2 point, float degrees)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 RotatePoint(Vector2 point, Vector2 around, float degrees)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float SmoothStep(float a, float b, float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float LinearStep(float a, float b, float t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static double Wrap(double value, double min, double max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float Wrap(float value, float min, float max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int Wrap(int value, int min, int max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static double DiscardLeastSignificantDecimal(double v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float ClampWrapAngle(float angle, float min, float max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int GetNumberOfDecimalsForMinimumDifference(double minDifference)
		{
			throw null;
		}
	}
}
