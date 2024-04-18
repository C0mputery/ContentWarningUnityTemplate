using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class BoundsFormatter : MinimalBaseFormatter<Bounds>
	{
		private static readonly Serializer<Vector3> Vector3Serializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Bounds value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Bounds value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BoundsFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BoundsFormatter()
		{
			throw null;
		}
	}
}
