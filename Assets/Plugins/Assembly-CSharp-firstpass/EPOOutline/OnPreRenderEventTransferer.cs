using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline
{
	[ExecuteAlways]
	public class OnPreRenderEventTransferer : MonoBehaviour
	{
		private Camera attachedCamera;

		public Action<Camera> OnPreRenderEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPreRender()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnPreRenderEventTransferer()
		{

		}
	}
}
