using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;
using Zorro.Core.CLI;

public class VideoDebugPage : DebugPage
{
	private VisualElement m_contentParent;

	private VisualTreeAsset m_videoCellTemplate;

	private VisualTreeAsset m_clipCell;

	private VisualTreeAsset m_contentCell;

	private Label m_currentlySharingLabel;

	private Dictionary<VideoHandle, DebugRecordingCell> m_recordingCells;

	private VisualElement m_queueParent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoDebugPage(VisualTreeAsset visualTreeAsset, VisualTreeAsset videoCellTemplate, VisualTreeAsset clipCell, VisualTreeAsset contentCell)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRecording(CameraRecording cameraRecorder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update()
	{
		throw null;
	}
}
