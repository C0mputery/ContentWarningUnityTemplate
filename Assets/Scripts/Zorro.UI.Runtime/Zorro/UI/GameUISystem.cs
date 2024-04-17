using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.UI
{
	public abstract class GameUISystem : MonoBehaviour
	{
		public abstract bool NeedsCursor();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ShouldShow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GameUISystem()
		{
			throw null;
		}
	}
}
