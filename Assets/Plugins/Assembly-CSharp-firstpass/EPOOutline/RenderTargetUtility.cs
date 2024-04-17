using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	public static class RenderTargetUtility
	{
		public struct RenderTextureInfo
		{
			public readonly RenderTextureDescriptor Descriptor;

			public readonly FilterMode FilterMode;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RenderTextureInfo(RenderTextureDescriptor descriptor, FilterMode filterMode)
			{
				throw null;
			}
		}

		private static RenderTextureFormat? hdrFormat;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDepthSliceForEye(StereoTargetEyeMask mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RenderTargetIdentifier ComposeTarget(OutlineParameters parameters, RenderTargetIdentifier target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsUsingVR(OutlineParameters parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RenderTextureInfo GetTargetInfo(OutlineParameters parameters, int width, int height, int depthBuffer, bool forceNoAA, bool noFiltering)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetTemporaryRT(OutlineParameters parameters, int id, int width, int height, int depthBuffer, bool clear, bool forceNoAA, bool noFiltering)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static RenderTextureFormat GetHDRFormat()
		{
			throw null;
		}
	}
}
