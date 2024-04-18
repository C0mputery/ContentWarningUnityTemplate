using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CommentUI : MonoBehaviour
{
	public TextMeshProUGUI m_faceText;

	public Graphic m_faceColor;

	public TextMeshProUGUI m_text;

	public TextMeshProUGUI m_likes;

	private CanvasGroup m_canvasGroup;

	private Vector2 m_originaAnchorPos;

	private float m_movedDown;

	private float m_alpha;

	private int targetLikes;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Setup(Comment comment)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Move(float delta)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommentUI()
	{

	}
}
