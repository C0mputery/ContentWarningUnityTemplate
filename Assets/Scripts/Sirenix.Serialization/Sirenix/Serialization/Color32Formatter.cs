using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class Color32Formatter : MinimalBaseFormatter<Color32>
	{
		private static readonly Serializer<byte> ByteSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Color32 value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Color32 value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color32Formatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Color32Formatter()
		{
			throw null;
		}
	}
}
