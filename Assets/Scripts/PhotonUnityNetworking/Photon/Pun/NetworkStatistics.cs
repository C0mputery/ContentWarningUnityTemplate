using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Pun
{
	public static class NetworkStatistics
	{
		private static Dictionary<string, int> m_RPCsCalledDictionary;

		private static Dictionary<string, int> m_RPCsReceivedDictionary;

		private static Dictionary<string, int> m_EventsCalledDictionary;

		private static Dictionary<string, int> m_EventsReceivedDictionary;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResetStats()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddRPC_Called(string rpcName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddRPC_Received(string rpcName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddEvent_Called(string eventName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddEvent_Received(string eventName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrintStatistcs()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NetworkStatistics()
		{
			throw null;
		}
	}
}
