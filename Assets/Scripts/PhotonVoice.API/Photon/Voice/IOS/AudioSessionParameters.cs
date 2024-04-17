using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice.IOS
{
	[Serializable]
	public struct AudioSessionParameters
	{
		public AudioSessionCategory Category;

		public AudioSessionMode Mode;

		public AudioSessionCategoryOption[] CategoryOptions;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CategoryOptionsToInt()
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
