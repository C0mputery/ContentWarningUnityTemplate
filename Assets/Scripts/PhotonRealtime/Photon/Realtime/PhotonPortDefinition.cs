using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public struct PhotonPortDefinition
	{
		public static readonly PhotonPortDefinition AlternativeUdpPorts;

		public ushort NameServerPort;

		public ushort MasterServerPort;

		public ushort GameServerPort;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PhotonPortDefinition()
		{
			throw null;
		}
	}
}
