using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtGameObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsInLayer(this GameObject me, LayerMask layerMask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetLayer(this GameObject me, int layer, bool includeChildren = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T PGetComponentInChildrenButNotMe<T>(this GameObject me, bool includeInActive = false) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _g<T>(this GameObject me, out T target) where T : Component
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _gp<T>(this GameObject me, out T target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _gc<T>(this GameObject me, out T target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool CompareGOS(GameObject[] go1, GameObject[] go2)
		{
			throw null;
		}
	}
}
