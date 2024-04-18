using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector2IntFormatter : MinimalBaseFormatter<Vector2Int>
	{
		private static readonly Serializer<int> Serializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Vector2Int value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Vector2Int value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2IntFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Vector2IntFormatter()
		{
			throw null;
		}
	}
}
