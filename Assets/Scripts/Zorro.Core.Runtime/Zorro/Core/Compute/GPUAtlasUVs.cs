using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Zorro.Core.Compute
{
	[Serializable]
	public struct GPUAtlasUVs
	{
		public const int Stride = 16;

		public float2 Offset;

		public float2 Size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GPUAtlasUVs(float2 offset, float2 size)
		{
			throw null;
		}
	}
}
