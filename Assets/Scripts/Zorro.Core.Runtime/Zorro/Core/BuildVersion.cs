using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	[Serializable]
	public struct BuildVersion
	{
		public int MajorVersion;

		public int MinorVersion;

		public char PatchVersion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BuildVersion(string version)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToMatchmaking()
		{
			throw null;
		}
	}
}
