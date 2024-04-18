using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization.Utilities
{
	internal static class UnityVersion
	{
		public static readonly int Major;

		public static readonly int Minor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnityVersion()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void EnsureLoaded()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsVersionOrGreater(int major, int minor)
		{
			throw null;
		}
	}
}
