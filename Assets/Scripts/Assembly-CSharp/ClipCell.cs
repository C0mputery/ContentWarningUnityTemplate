using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

public class ClipCell : VisualElement
{
	public enum Background
	{
		INVALID = 0,
		Recording = 1,
		Local = 2,
		Encoded = 3,
		Remote = 4,
		Error = 5,
		Recieved = 6
	}

	private Clip m_clip;

	private Background m_background;

	private VisualElement m_backgroundElement;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClipCell(VisualTreeAsset visualTreeAsset, Clip clip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBackground(Background background)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetBackgroundStyle(Background style)
	{
		throw null;
	}
}
