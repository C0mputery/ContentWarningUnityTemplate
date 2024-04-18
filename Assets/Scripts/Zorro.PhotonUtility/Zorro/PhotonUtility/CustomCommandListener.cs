using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using Zorro.Core;

namespace Zorro.PhotonUtility
{
	public class CustomCommandListener<CommandEnum> : Singleton<CustomCommandListener<CommandEnum>>, IConnectionCallbacks, IOnEventCallback where CommandEnum : struct, IConvertible
	{
		private bool isCallback;

		private static Dictionary<byte, Type> m_registeredPackages;

		private static Dictionary<ListenerHandle, Action<CustomCommandPackage<CommandEnum>>> m_listeners;

		private static Dictionary<Type, List<ListenerHandle>> m_listenerHandlesForType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnCreated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterPackage<T>(T package) where T : CustomCommandPackage<CommandEnum>
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEvent(EventData photonEvent)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnConnected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnConnectedToMaster()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisconnected(DisconnectCause cause)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomCommandListener()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CustomCommandListener()
		{
			throw null;
		}
	}
}
