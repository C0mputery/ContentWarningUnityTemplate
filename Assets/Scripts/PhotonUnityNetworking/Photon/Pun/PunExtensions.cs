using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public static class PunExtensions
	{
		public static Dictionary<MethodInfo, ParameterInfo[]> ParametersOfMethods;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ParameterInfo[] GetCachedParemeters(this MethodInfo mo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PhotonView[] GetPhotonViewsInChildren(this GameObject go)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PhotonView GetPhotonView(this GameObject go)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AlmostEquals(this Vector3 target, Vector3 second, float sqrMagnitudePrecision)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AlmostEquals(this Vector2 target, Vector2 second, float sqrMagnitudePrecision)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AlmostEquals(this Quaternion target, Quaternion second, float maxAngle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AlmostEquals(this float target, float second, float floatDiff)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckIsAssignableFrom(this Type to, Type from)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckIsInterface(this Type to)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PunExtensions()
		{
			throw null;
		}
	}
}
