namespace Photon.Voice
{
	public struct VoiceCreateOptions
	{
		public IEncoder Encoder;

		public byte InterestGroup;

		public int[] TargetPlayers;

		public bool DebugEchoMode;

		public bool Reliable;

		public bool Encrypt;

		public bool Fragment;

		public int FEC;
	}
}
