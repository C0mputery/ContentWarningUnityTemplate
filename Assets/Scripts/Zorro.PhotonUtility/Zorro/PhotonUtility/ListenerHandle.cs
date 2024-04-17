using System;
using System.Runtime.CompilerServices;

namespace Zorro.PhotonUtility
{
	public struct ListenerHandle : IComparable<ListenerHandle>
	{
		public Guid id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public static ListenerHandle Invalid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ListenerHandle Create()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CompareTo(ListenerHandle other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
