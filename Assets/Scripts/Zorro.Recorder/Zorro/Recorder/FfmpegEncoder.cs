using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Zorro.Recorder
{
	public class FfmpegEncoder
	{
		[CompilerGenerated]
		private sealed class _003CEncode_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FfmpegEncoder _003C_003E4__this;

			public bool mic;

			public byte framerate;

			public FfmpegDeadline deadline;

			public bool displayWindow;

			private DirectoryInfo _003Cdirectory_003E5__2;

			private int _003CaudioSampleRate_003E5__3;

			private int _003CmicSampleRate_003E5__4;

			private int _003CmicChannels_003E5__5;

			private string _003CfullAudioPath_003E5__6;

			private string _003CfullMicAudioPath_003E5__7;

			private int _003CframeCount_003E5__8;

			private float _003Cduration_003E5__9;

			private string _003CoutputPath_003E5__10;

			object IEnumerator<object>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003CEncode_003Ed__5(int _003C_003E1__state)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				throw null;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CRunFfmpeg_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string arguments;

			public FfmpegEncoder _003C_003E4__this;

			public bool displayWindow;

			private Stopwatch _003Cstopwatch_003E5__2;

			object IEnumerator<object>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003CRunFfmpeg_003Ed__7(int _003C_003E1__state)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				throw null;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		private Process m_ffmpegProcess;

		private RecordingSession m_session;

		public static string ExecutablePath
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FfmpegEncoder(RecordingSession session)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CEncode_003Ed__5))]
		public IEnumerator Encode(byte framerate, FfmpegDeadline deadline, bool displayWindow, bool mic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SaveAudioBlobs(bool saveMic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CRunFfmpeg_003Ed__7))]
		private IEnumerator RunFfmpeg(string arguments, bool displayWindow)
		{
			throw null;
		}
	}
}
