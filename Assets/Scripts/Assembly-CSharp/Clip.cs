using System;
using System.Runtime.CompilerServices;
using Zorro.Recorder;

[Serializable]
public class Clip
{
	public CameraRecording m_recording;

	public ClipID clipID;

	public bool local;

	public int ownerID;

	public bool isRecording;

	public bool encoded;

	public bool hasBeenRecieved;

	public float m_timeStarted;

	private ContentBuffer m_contentBuffer;

	private VideoRecorder m_recorder;

	public bool Valid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Clip(ClipID clipID, bool local, int ownerID, CameraRecording recording)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndClip()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecorder(VideoRecorder recorder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoRecorder GetRecorder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetClipDirectory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetContentBufffer(ContentBuffer contentBuffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetContentBuffer(out ContentBuffer contentBuffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetValid(bool validClip)
	{
		throw null;
	}
}
