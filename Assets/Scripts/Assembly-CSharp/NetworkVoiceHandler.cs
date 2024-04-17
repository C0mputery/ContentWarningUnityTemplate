using System.Runtime.CompilerServices;
using Photon.Realtime;
using Photon.Voice.Unity;
using UnityEngine;

public class NetworkVoiceHandler : MonoBehaviour
{
	private const byte ALIVE_CHANNEL = 1;

	private const byte DEAD_CHANNEL = 2;

	private static VoiceConnection m_VoiceConnection;

	private static Recorder m_LocalRecorder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LocalPlayerAssigned(Player p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStateChanged(ClientState state, ClientState toState)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitNetworkVoice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ListenAndSendToAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TalkToDead()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TalkToAlive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkVoiceHandler()
	{
		throw null;
	}
}
