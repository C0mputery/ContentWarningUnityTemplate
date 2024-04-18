using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice.Unity
{
	public class RemoteVoiceLink
	{
		public readonly VoiceInfo VoiceInfo;

		public readonly int PlayerId;

		public readonly byte VoiceId;

		public readonly int ChannelId;

		private string cached;

		public event Action<FrameOut<float>> FloatFrameDecoded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event Action RemoteVoiceRemoved
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoteVoiceLink(VoiceInfo info, int playerId, byte voiceId, int channelId, ref RemoteVoiceOptions options)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRemoteVoiceRemoveAction()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDecodedFrameFloatAction(FrameOut<float> floats)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
