using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class ContentPolling
{
	private const int m_resolution = 20;

	private static Camera m_currentPollingCamera;

	private static int m_currentPollingY;

	private static List<ContentEventFrame> contentEvents;

	private static Dictionary<ContentProvider, int> contentProviders;

	private static float m_clipTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartPolling(Camera camera, float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TickPoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Poll(int x, int y, Camera camera)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CompletePolling(out List<ContentEventFrame> eventFrames)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ContentEventFrame> CombineAndGetBestContentEvent(List<ContentEventFrame> events)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ContentEventFrame> CombineDuplicateContentEvents(List<ContentEventFrame> events)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContentPolling()
	{
		throw null;
	}
}
