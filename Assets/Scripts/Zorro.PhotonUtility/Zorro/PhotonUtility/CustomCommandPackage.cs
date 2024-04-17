using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Zorro.Core.Serizalization;

namespace Zorro.PhotonUtility
{
	public abstract class CustomCommandPackage<CommandEnum> where CommandEnum : struct, IConvertible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinarySerializer Serialize()
		{
			throw null;
		}

		protected abstract void SerializeData(BinarySerializer binarySerializer);

		public abstract void DeserializeData(BinaryDeserializer binaryDeserializer);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte GetCommandEventCode()
		{
			throw null;
		}

		public abstract CommandEnum GetCommandType();

		public abstract SendOptions GetSendOptions();

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CustomCommandPackage()
		{
			throw null;
		}
	}
}
