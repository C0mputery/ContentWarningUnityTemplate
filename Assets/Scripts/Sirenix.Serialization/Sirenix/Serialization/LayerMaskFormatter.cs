using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class LayerMaskFormatter : MinimalBaseFormatter<LayerMask>
	{
		private static readonly Serializer<int> IntSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref LayerMask value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref LayerMask value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LayerMaskFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LayerMaskFormatter()
		{
			throw null;
		}
	}
}
