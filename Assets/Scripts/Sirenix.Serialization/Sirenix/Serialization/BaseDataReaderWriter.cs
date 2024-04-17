using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class BaseDataReaderWriter
	{
		private NodeInfo[] nodes;

		private int nodesLength;

		[Obsolete("Use the Binder member on the writer's SerializationContext/DeserializationContext instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TwoWaySerializationBinder Binder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool IsInArrayNode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected int NodeDepth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected NodeInfo[] NodesArray
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected NodeInfo CurrentNode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PushNode(NodeInfo node)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PushNode(string name, int id, Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PushArray()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExpandNodes()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PopNode(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PopArray()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ClearNodes()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BaseDataReaderWriter()
		{
			throw null;
		}
	}
}
