using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public static class GameObjectExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetLayerRecursivly(this GameObject gameObject, int layer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T FetchComponent<T>(this GameObject gameObject) where T : Component
		{
			throw null;
		}
	}
}
