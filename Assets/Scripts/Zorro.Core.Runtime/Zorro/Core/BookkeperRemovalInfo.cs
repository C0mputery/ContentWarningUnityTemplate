using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public struct BookkeperRemovalInfo
	{
		public int IndexRemoved;

		public int SwapbackIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookkeperRemovalInfo(int indexRemoved, int swapbackIndex)
		{
			throw null;
		}
	}
}
