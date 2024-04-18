using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zorro.Core;

public class CameraHandler : Singleton<CameraHandler>
{
	private Dictionary<Guid, VideoCamera> m_cameras;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterCamera(Guid id, VideoCamera camera)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterCamera(Guid id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetCamera(Guid instanceDataGuid, out VideoCamera videoCamera)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraHandler()
	{

	}
}
