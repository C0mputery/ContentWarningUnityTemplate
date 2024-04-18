using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace CurvedUI
{
	public class CurvedUIEventSystem : EventSystem
	{
		public static CurvedUIEventSystem instance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUIEventSystem()
		{

		}
	}
}
