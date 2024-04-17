using System.Runtime.CompilerServices;

namespace Zorro.UI
{
	public abstract class UIPage : PageBase
	{
		protected UIPageHandler pageHandler;

		private UISubPage currentSubPage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual UISubPage[] GetSubPages()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPageEnter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TransistionToSubPage(UISubPage subPage, PageTransistion pageTransistion)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T GetPageHandler<T>() where T : UIPageHandler
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected UIPage()
		{
			throw null;
		}
	}
}
