using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtDebug
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PDebug(this Vector3 me, string pretext = "")
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PDebug(this bool me, string preText = "")
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PDebug(this string me, string preText = "")
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PDebug(this float me, string preText = "")
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PDebug<T>(this T me, string preText = "")
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PDraw(this Vector3 me, Vector3 start, float mul = 1f, Color? c = null)
		{
			throw null;
		}
	}
}
