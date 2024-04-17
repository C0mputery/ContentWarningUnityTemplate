using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CurvedUI
{
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[SerializeField]
		protected int sortOrder;

		private RaycastHit hitInfo;

		private RaycastResult result;

		public int CompoundEventMask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override Camera eventCamera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual int Depth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override int sortOrderPriority
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CurvedUIPhysicsRaycaster()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw null;
		}
	}
}
