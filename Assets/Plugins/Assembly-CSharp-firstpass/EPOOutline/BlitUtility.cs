using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	public static class BlitUtility
	{
		public struct MeshSetupResult
		{
			public readonly int VertexIndex;

			public readonly int TriangleIndex;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MeshSetupResult(int vertexIndex, int triangleIndex)
			{
				throw null;
			}
		}

		public struct Vertex
		{
			public Vector4 Position;

			public Vector3 Normal;
		}

		private static readonly int MainTexHash;

		private static Vector4[] normals;

		private static Vector4[] tempVertecies;

		private static VertexAttributeDescriptor[] vertexParams;

		private static ushort[] indecies;

		private static Vertex[] vertices;

		private static Matrix4x4[] matrices;

		private static int itemsToDraw;

		private static bool? supportsInstancing;

		private static bool SupportsInstancing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void UpdateBounds(Renderer renderer, OutlineTarget target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrepareForRendering(OutlineParameters parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MeshSetupResult? SetupForInstancing(OutlineParameters parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MeshSetupResult? SetupForBruteForce(OutlineParameters parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Blit(OutlineParameters parameters, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier destinationDepth, Material material, CommandBuffer targetBuffer, int pass = -1, Rect? viewport = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Draw(OutlineParameters parameters, RenderTargetIdentifier target, RenderTargetIdentifier depth, Material material, Rect? viewport = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlitUtility()
		{
			throw null;
		}
	}
}
