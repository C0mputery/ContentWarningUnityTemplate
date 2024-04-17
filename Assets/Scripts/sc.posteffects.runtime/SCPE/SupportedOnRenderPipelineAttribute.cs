using System;
using System.Runtime.CompilerServices;

namespace SCPE
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class SupportedOnRenderPipelineAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SupportedOnRenderPipelineAttribute(params Type[] renderPipeline)
		{
			throw null;
		}
	}
}
