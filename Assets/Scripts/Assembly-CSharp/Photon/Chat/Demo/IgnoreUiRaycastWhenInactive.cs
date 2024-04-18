using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Chat.Demo
{
	public class IgnoreUiRaycastWhenInactive : MonoBehaviour, ICanvasRaycastFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IgnoreUiRaycastWhenInactive()
		{

		}
	}
}
