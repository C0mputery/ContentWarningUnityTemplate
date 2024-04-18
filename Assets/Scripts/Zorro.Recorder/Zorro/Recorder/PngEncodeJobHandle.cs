using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;

namespace Zorro.Recorder
{
	public class PngEncodeJobHandle
	{
		public JobHandle JobHandle;

		public NativeList<byte> OutputBuffer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PngEncodeJobHandle(JobHandle jobHandle, NativeList<byte> outputBuffer)
		{

		}
	}
}
