using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Zorro.Recorder.ImageEncoding
{
	[BurstCompile]
	public struct EncodePngJob : IJob
	{
		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<byte> Input;

		public uint Width;

		public uint Height;

		public NativeList<byte> Output;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}
	}
}
