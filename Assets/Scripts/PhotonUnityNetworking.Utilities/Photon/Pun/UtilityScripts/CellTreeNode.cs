using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun.UtilityScripts
{
	public class CellTreeNode
	{
		public enum ENodeType : byte
		{
			Root = 0,
			Node = 1,
			Leaf = 2
		}

		public byte Id;

		public Vector3 Center;

		public Vector3 Size;

		public Vector3 TopLeft;

		public Vector3 BottomRight;

		public ENodeType NodeType;

		public CellTreeNode Parent;

		public List<CellTreeNode> Childs;

		private float maxDistance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CellTreeNode()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CellTreeNode(byte id, ENodeType nodeType, CellTreeNode parent)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddChild(CellTreeNode child)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetActiveCells(List<byte> activeCells, bool yIsUpAxis, Vector3 position)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPointInsideCell(bool yIsUpAxis, Vector3 point)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPointNearCell(bool yIsUpAxis, Vector3 point)
		{
			throw null;
		}
	}
}
