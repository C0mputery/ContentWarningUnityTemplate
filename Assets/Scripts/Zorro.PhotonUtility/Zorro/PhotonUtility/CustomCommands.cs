using System;
using System.Runtime.CompilerServices;
using Photon.Realtime;

namespace Zorro.PhotonUtility
{
	public static class CustomCommands<CommandEnum> where CommandEnum : struct, IConvertible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SendPackage(CustomCommandPackage<CommandEnum> commandPackage, ReceiverGroup receiverGroup)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SendPackage(CustomCommandPackage<CommandEnum> commandPackage, RaiseEventOptions eventOptions)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T SpawnCommandListener<T>() where T : CustomCommandListener<CommandEnum>
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ListenerHandle RegisterListener<T>(Action<T> onReceived) where T : CustomCommandPackage<CommandEnum>
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnregisterListener(ListenerHandle handle)
		{
			throw null;
		}
	}
}
