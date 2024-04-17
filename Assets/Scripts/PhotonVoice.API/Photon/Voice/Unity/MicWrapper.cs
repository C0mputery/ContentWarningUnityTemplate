using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioDesc
	{
		private AudioClip mic;

		private string device;

		private ILogger logger;

		private int micPrevPos;

		private int micLoopCnt;

		private int readAbsPos;

		public int SamplingRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Channels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MicWrapper(string device, int suggestedFrequency, ILogger logger)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Read(float[] buffer)
		{
			throw null;
		}
	}
}
