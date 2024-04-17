using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public static class NormalSolver
	{
		private struct VertexKey
		{
			private readonly long _x;

			private readonly long _y;

			private readonly long _z;

			private const int Tolerance = 100000;

			private const long FNV32Init = 2166136261L;

			private const long FNV32Prime = 16777619L;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VertexKey(Vector3 position)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override int GetHashCode()
			{
				throw null;
			}
		}

		private struct VertexEntry
		{
			public readonly int MeshIndex;

			public readonly int TriangleIndex;

			public readonly int VertexIndex;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VertexEntry(int meshIndex, int triIndex, int vertIndex)
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PRecalculateNormals(this Mesh mesh, float angle)
		{
			throw null;
		}
	}
}
