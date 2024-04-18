using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun.UtilityScripts
{
	public class CullArea : MonoBehaviour
	{
		private const int MAX_NUMBER_OF_ALLOWED_CELLS = 250;

		public const int MAX_NUMBER_OF_SUBDIVISIONS = 3;

		public readonly byte FIRST_GROUP_ID;

		public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER;

		public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER;

		public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER;

		public Vector2 Center;

		public Vector2 Size;

		public Vector2[] Subdivisions;

		public int NumberOfSubdivisions;

		public bool YIsUpAxis;

		public bool RecreateCellHierarchy;

		private byte idCounter;

		public int CellCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
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

		public CellTree CellTree
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
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

		public Dictionary<int, GameObject> Map
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmos()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateCellHierarchy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateChildCells(CellTreeNode parent, int cellLevelInHierarchy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawCells()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsCellCountAllowed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<byte> GetActiveCells(Vector3 position)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CullArea()
		{

		}
	}
}
