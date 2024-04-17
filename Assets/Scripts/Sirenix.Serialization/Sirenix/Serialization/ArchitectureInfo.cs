using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class ArchitectureInfo
	{
		public static bool Architecture_Supports_Unaligned_Float32_Reads;

		public static bool Architecture_Supports_All_Unaligned_ReadWrites;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArchitectureInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SetRuntimePlatform(RuntimePlatform platform)
		{
			throw null;
		}
	}
}
