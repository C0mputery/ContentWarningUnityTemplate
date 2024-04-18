using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class RectFormatter : MinimalBaseFormatter<Rect>
	{
		private static readonly Serializer<float> FloatSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Rect value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Rect value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RectFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RectFormatter()
		{
			throw null;
		}
	}
}
