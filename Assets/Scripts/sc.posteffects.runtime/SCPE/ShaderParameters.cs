using System.Runtime.CompilerServices;

namespace SCPE
{
	public static class ShaderParameters
	{
		public static int _BlitScaleBiasRt;

		public static int _BlitScaleBias;

		public static int _DeferredRendering;

		public static int unity_WorldToLight;

		public static int Params;

		public static int FadeParams;

		public static int BlurOffsets;

		public static int BlurRadius;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShaderParameters()
		{
			throw null;
		}
	}
}
