using System.Runtime.CompilerServices;

namespace Zorro.UI
{
	public abstract class PageTransistion
	{
		public abstract void Transistion(PageBase oldSubPage, PageBase newSubPage);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PageTransistion()
		{
			throw null;
		}
	}
}
