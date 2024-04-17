using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Zorro.Core
{
	public struct Bounds2D
	{
		public float2 Center;

		public float2 HalfSize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bounds2D(float2 center, float2 halfSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		public bool Contains(float2 point)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Overlaps(Bounds2D bounds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		public bool Overlaps(Box2D bounds)
		{
			throw null;
		}
	}
}
