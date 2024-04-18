using System;
using System.Runtime.CompilerServices;

namespace pworld.Scripts.Extensions
{
	public class PValueWatch
	{
		public Action<IComparable> alternativeCompare;

		public Action<int> onValueChanged;

		public IComparable valueWatched;

		public IComparable ValueWatched
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PValueWatch(IComparable val, Action<int> cb, Action<IComparable> alternativeCompare = null)
		{

		}
	}
}
