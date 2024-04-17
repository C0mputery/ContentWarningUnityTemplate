using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal class EnetChannel
	{
		internal byte ChannelNumber;

		internal NonAllocDictionary<int, NCommand> incomingReliableCommandsList;

		internal NonAllocDictionary<int, NCommand> incomingUnreliableCommandsList;

		internal Queue<NCommand> incomingUnsequencedCommandsList;

		internal NonAllocDictionary<int, NCommand> incomingUnsequencedFragments;

		internal Queue<NCommand> outgoingReliableCommandsList;

		internal Queue<NCommand> outgoingUnreliableCommandsList;

		internal int incomingReliableSequenceNumber;

		internal int incomingUnreliableSequenceNumber;

		internal int outgoingReliableSequenceNumber;

		internal int outgoingUnreliableSequenceNumber;

		internal int outgoingReliableUnsequencedNumber;

		private int reliableUnsequencedNumbersCompletelyReceived;

		private HashSet<int> reliableUnsequencedNumbersReceived;

		internal int highestReceivedAck;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnetChannel(byte channelNumber, int commandBufferSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsUnreliableSequenceNumber(int unreliableSequenceNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NCommand FetchUnreliableSequenceNumber(int unreliableSequenceNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsReliableSequenceNumber(int reliableSequenceNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NCommand FetchReliableSequenceNumber(int reliableSequenceNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetFragment(int reliableSequenceNumber, bool isSequenced, out NCommand fragment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFragment(int reliableSequenceNumber, bool isSequenced)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void clearAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool QueueIncomingReliableUnsequenced(NCommand command)
		{
			throw null;
		}
	}
}
