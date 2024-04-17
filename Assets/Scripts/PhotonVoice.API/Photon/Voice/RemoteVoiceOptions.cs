using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public struct RemoteVoiceOptions
	{
		private readonly ILogger logger;

		private readonly VoiceInfo voiceInfo;

		public Action OnRemoteVoiceRemoveAction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public IDecoder Decoder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		internal readonly string logPrefix
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoteVoiceOptions(ILogger logger, string logPrefix, VoiceInfo voiceInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOutput(Action<FrameOut<float>> output)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOutput(Action<FrameOut<short>> output)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setOutput<T>(Action<FrameOut<T>> output)
		{
			throw null;
		}
	}
}
