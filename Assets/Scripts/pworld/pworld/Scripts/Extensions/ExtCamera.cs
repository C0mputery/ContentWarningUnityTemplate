using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtCamera
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsVisibleToCamera(this Camera me, Vector3 position)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 GetMousePosInWorld(this Camera me)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 ManualWorldToScreenPoint(Vector3 wp, Camera cam)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 ManualWorldToScreenUV(Vector3 wp, Matrix4x4 projMat, Matrix4x4 worldToCamMat)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int CountCornersVisibleFrom(this RectTransform rectTransform, Camera camera)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PIsFullyVisibleFrom(this RectTransform rectTransform, Camera camera)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PIsVisibleFrom(this RectTransform rectTransform, Camera camera)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Overlap(this Camera cam, RectTransform elem, RectTransform viewport = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Contains(this Camera cam, RectTransform elem, RectTransform viewport = null)
		{
			throw null;
		}
	}
}
