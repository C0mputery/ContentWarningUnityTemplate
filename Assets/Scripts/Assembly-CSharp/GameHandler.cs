using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using Zorro.Core.CLI;

public class GameHandler : DisableIntercept
{
	private struct PluginInfo
	{
		public int version;

		public int guid;

		public int name;
	}

	private static GameHandler _instance;

	private static Hash128? m_pluginHash;

	public static GameHandler Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public SettingsHandler SettingsHandler
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPlugins()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void JoinRandom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetPluginHash()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanIntercept()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameHandler()
	{

	}
}
