using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Profiling;

namespace Zorro.Recorder
{
	public class RecordingPipe : IDisposable
	{
		private uint m_width;

		private uint m_height;

		private int m_frameCount;

		private Queue<PngEncodeJobHandle> m_encodePngJobHandles;

		private ProfilerMarker m_flushMarker;

		private static string tempPath;

		private string path;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DirectoryInfo GetDirectory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecordingPipe(uint width, uint height, string directory)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Flush()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FlushLastHandle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushFrameData(NativeArray<byte> getData)
		{
			throw null;
		}
	}
}
