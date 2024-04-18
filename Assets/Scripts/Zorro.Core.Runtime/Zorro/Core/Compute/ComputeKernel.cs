using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace Zorro.Core.Compute
{
	public class ComputeKernel
	{
		public int kernelID;

		private ComputeShader m_computeShader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ComputeKernel(ComputeShader computeShader, string kernelName)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispatch(int3 dispatchSize)
		{
			throw null;
		}
	}
}
