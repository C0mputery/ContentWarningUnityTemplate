using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core.Compute
{
	public class GPUTextureAtlasDescriptor : ScriptableObject
	{
		public Texture2D Atlas;

		public GPUAtlasUVs[] UVs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GPUTextureAtlasDescriptor()
		{
			throw null;
		}
	}
}
