using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Photon.Voice
{
	public class LocalVoiceFramed<T> : LocalVoice
	{
		private Framer<T> framer;

		private int preProcessorsCnt;

		private List<IProcessor<T>> processors;

		private bool dataEncodeThreadStarted;

		private Queue<T[]> pushDataQueue;

		private AutoResetEvent pushDataQueueReady;

		private FactoryPrimitiveArrayPool<T> bufferFactory;

		private int framesSkippedNextLog;

		private int framesSkipped;

		private bool exitThread;

		private int processNullFramesCnt;

		public FactoryPrimitiveArrayPool<T> BufferFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool PushDataAsyncReady
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected T[] processFrame(T[] buf, int p0, int p1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPostProcessor(params IProcessor<T>[] processors)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPreProcessor(params IProcessor<T>[] processors)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveProcessor(params IProcessor<T>[] processors)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearProcessors()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocalVoiceFramed(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, int inSampleRate, int channelId, VoiceCreateOptions opt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushDataAsync(T[] buf)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PushDataAsyncThread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushData(T[] buf)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}
	}
}
