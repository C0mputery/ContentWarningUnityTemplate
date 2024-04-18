using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector4Formatter : MinimalBaseFormatter<Vector4>
	{
		private static readonly Serializer<float> FloatSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Vector4 value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Vector4 value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector4Formatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Vector4Formatter()
		{
			throw null;
		}
	}
}
