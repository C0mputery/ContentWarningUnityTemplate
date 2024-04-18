using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using Zorro.Core;

[CreateAssetMenu(fileName = "RecordingPageInitter", menuName = "Zorro/RecordingPageInitter")]
public class RecordingPageInitter : SingletonAsset<RecordingPageInitter>
{
	[SerializeField]
	private VisualTreeAsset m_videoPage;

	[SerializeField]
	private VisualTreeAsset m_videoCellTemplate;

	[SerializeField]
	private VisualTreeAsset m_clipCell;

	[SerializeField]
	private VisualTreeAsset m_contentCell;

	[SerializeField]
	private VisualTreeAsset m_roomStatsPage;

	[SerializeField]
	private VisualTreeAsset m_roomStatsCell;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RecordingPageInitter()
	{

	}
}
