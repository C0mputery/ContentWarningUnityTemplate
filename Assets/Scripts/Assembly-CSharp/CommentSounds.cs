using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CommentSounds : MonoBehaviour
{
	public GameObject playVideo;

	public Transform commentParent;

	public SFX_Instance[] viewSound;

	public SFX_Instance[] commentSfx;

	private int childCount;

	public TextMeshProUGUI viewCount;

	private bool t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommentSounds()
	{

	}
}
