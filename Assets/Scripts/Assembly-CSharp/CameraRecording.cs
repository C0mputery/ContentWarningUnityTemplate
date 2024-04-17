using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraRecording : MonoBehaviour, IPlayableVideo
{
	public VideoHandle videoHandle;

	private List<Clip> m_clips;

	public int ClipCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool ReadyToExtract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInfo(VideoHandle videoID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNewClip(Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Clip EndCurrentClip()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Clip GetClip(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Clip GetClip(ClipID clipID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDirectory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Clip> GetAllClips()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetLatestClip(out Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SaveToDesktop(out string videoFileName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetClip(ClipID clipID, out Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetVideoPath(out string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraRecording()
	{
		throw null;
	}
}
