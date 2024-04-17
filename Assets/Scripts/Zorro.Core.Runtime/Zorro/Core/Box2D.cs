using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Zorro.Core
{
	public struct Box2D
	{
		public float2 Center;

		public float HalfHeight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Box2D(float2 center, float halfHeight)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		public bool Contains(float2 point)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
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
