using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtCollections
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<T> PToList<T>(this T me)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PGetRandomIndex<T>(this List<T> me)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PPushRange<T>(this Stack<T> source, IEnumerable<T> collection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T[][] PToJaggedArray<T>(this T[,] twoDimensionalArray)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T FindClosest<T>(this Vector3 pos, List<T> list) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Transform FindClosest(this List<Transform> list, Vector3 position)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T FindClosest<T>(this List<T> list, Vector3 position) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetFromBack<T>(this List<T> me, int nrFromBack = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ForEachBackwards<T>(this List<T> me, Action<T> doIt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetRnd<T>(this List<T> me)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IList<T> Shuffle<T>(this IList<T> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddRange<T>(this ObservableCollection<T> me, IEnumerable<T> range)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Contains<T>(this HashSet<T> me, List<T> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static (T[] first, T[] second) Split<T>(this T[] me, int split)
		{
			throw null;
		}
	}
}
