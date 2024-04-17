using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public abstract class BookkeepingRecord : IDisposable
	{
		public abstract void Dispose();

		public abstract void RemoveAtSwapBack(int index);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BookkeepingRecord()
		{
			throw null;
		}
	}
}
