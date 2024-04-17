namespace Zorro.UI
{
	public interface IHasParentPage
	{
		(UIPage, PageTransistion) GetParentPage();

		bool OnAttemptGoToParent()
		{
			return true;
		}
	}
}
