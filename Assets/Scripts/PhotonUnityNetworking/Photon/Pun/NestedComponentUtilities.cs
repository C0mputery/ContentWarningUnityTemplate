using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public static class NestedComponentUtilities
	{
		private static Queue<Transform> nodesQueue;

		public static Dictionary<Type, ICollection> searchLists;

		private static Stack<Transform> nodeStack;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T EnsureRootComponentExists<T, NestedT>(this Transform transform) where T : Component where NestedT : Component
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetParentComponent<T>(this Transform t) where T : Component
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetNestedComponentsInParents<T>(this Transform t, List<T> list) where T : Component
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetNestedComponentInChildren<T, NestedT>(this Transform t, bool includeInactive) where T : class where NestedT : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetNestedComponentInParent<T, NestedT>(this Transform t) where T : class where NestedT : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetNestedComponentInParents<T, NestedT>(this Transform t) where T : class where NestedT : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetNestedComponentsInParents<T, NestedT>(this Transform t, List<T> list) where T : class where NestedT : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<T> GetNestedComponentsInChildren<T, NestedT>(this Transform t, List<T> list, bool includeInactive = true) where T : class where NestedT : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<T> GetNestedComponentsInChildren<T>(this Transform t, List<T> list, bool includeInactive = true, params Type[] stopOn) where T : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetNestedComponentsInChildren<T, SearchT, NestedT>(this Transform t, bool includeInactive, List<T> list) where T : class where SearchT : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NestedComponentUtilities()
		{
			throw null;
		}
	}
}
