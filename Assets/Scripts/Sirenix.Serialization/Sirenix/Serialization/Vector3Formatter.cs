using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector3Formatter : MinimalBaseFormatter<Vector3>
	{
		private static readonly Serializer<float> FloatSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Vector3 value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Vector3 value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3Formatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Vector3Formatter()
		{
			throw null;
		}
	}
}
