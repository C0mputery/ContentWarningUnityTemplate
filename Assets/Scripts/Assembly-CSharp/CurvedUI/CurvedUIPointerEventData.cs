using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CurvedUI
{
	public class CurvedUIPointerEventData : PointerEventData
	{
		public enum ControllerType
		{
			NONE = -1,
			VIVE = 0
		}

		public GameObject Controller;

		public Vector2 TouchPadAxis;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUIPointerEventData(EventSystem eventSystem) : base(eventSystem)
		{
			throw null;
		}
	}
}
