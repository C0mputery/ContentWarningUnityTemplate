using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Zorro.Recorder
{
	public class QueuedFrame
	{
		public RenderTexture Frame;

		public AsyncGPUReadbackRequest ReadbackRequest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public QueuedFrame(RenderTexture frame, AsyncGPUReadbackRequest readbackRequest)
		{

		}
	}
}
