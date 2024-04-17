using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.UI
{
	public abstract class UIPageHandlerStartPageSelector : MonoBehaviour
	{
		public abstract UIPage GetStartPage();

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected UIPageHandlerStartPageSelector()
		{
			throw null;
		}
	}
}
