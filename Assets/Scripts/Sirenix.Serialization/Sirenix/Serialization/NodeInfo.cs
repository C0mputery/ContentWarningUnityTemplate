using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public struct NodeInfo
	{
		public static readonly NodeInfo Empty;

		public readonly string Name;

		public readonly int Id;

		public readonly Type Type;

		public readonly bool IsArray;

		public readonly bool IsEmpty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NodeInfo(string name, int id, Type type, bool isArray)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private NodeInfo(bool parameter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator ==(NodeInfo a, NodeInfo b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator !=(NodeInfo a, NodeInfo b)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NodeInfo()
		{
			throw null;
		}
	}
}
