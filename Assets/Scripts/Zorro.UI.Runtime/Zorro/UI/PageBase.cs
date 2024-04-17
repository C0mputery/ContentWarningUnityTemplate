using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.UI
{
	public abstract class PageBase : MonoBehaviour
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPageEnter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPageExit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPageEntered()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PageBase()
		{
			throw null;
		}
	}
}
