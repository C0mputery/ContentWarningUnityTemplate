using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector3IntFormatter : MinimalBaseFormatter<Vector3Int>
	{
		private static readonly Serializer<int> Serializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Vector3Int value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Vector3Int value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3IntFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Vector3IntFormatter()
		{
			throw null;
		}
	}
}
