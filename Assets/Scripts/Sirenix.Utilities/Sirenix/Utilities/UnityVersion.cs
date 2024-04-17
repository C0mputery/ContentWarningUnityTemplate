using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Utilities
{
	public static class UnityVersion
	{
		public static readonly int Major;

		public static readonly int Minor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnityVersion()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void EnsureLoaded()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsVersionOrGreater(int major, int minor)
		{
			throw null;
		}
	}
}
