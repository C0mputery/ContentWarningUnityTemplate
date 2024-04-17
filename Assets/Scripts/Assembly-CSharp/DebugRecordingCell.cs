using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

public class DebugRecordingCell : VisualElement
{
	private Label m_videoID;

	private Label m_cameraID;

	private VisualTreeAsset clipCell;

	private VisualTreeAsset contentCell;

	private CameraRecording m_recording;

	private Dictionary<ClipID, ClipCell> m_clipCells;

	private VisualElement m_clipParent;

	private VisualElement m_bestContentParent;

	private VisualElement m_commentsParent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DebugRecordingCell(VisualTreeAsset visualTreeAsset, VisualTreeAsset clipCell, VisualTreeAsset contentCell, CameraRecording cameraRecording)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(bool isRecording, Guid cameraID, int playerID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddClip(Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearContent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetContent(ContentBuffer contentBuffer)
	{
		throw null;
	}
}
