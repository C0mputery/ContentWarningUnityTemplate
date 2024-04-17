using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector2Formatter : MinimalBaseFormatter<Vector2>
	{
		private static readonly Serializer<float> FloatSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Vector2 value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Vector2 value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2Formatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Vector2Formatter()
		{
			throw null;
		}
	}
}
