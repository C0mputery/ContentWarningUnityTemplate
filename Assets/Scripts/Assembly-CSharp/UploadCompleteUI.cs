using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class UploadCompleteUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisplayVideoEval_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UploadCompleteUI _003C_003E4__this;

		public Comment[] comments;

		public int views;

		public CameraRecording recording;

		private float _003Ct_003E5__2;

		private float _003Ctime_003E5__3;

		private int _003CcommentIndex_003E5__4;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CDisplayVideoEval_003Ed__15(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public SaveVideoToDesktopInteractable m_saveToDesktopInteractable;

	public CanvasGroup m_saveToDesktopGroup;

	public AnimationCurve m_viewsCurve;

	public AnimationCurve m_saveToDesktopCurve;

	public TextMeshProUGUI m_views;

	public VideoPlayer m_videoPlayer;

	public GameObject m_commentsPrefab;

	public Transform m_commentsParent;

	public List<CommentUI> m_comments;

	private IPlayableVideo m_replayVideo;

	private int m_replayViews;

	private Comment[] m_replayComments;

	private Action m_onPlayed;

	private string m_ViewsText;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayVideo(IPlayableVideo playableVideo, int views, Comment[] comments, Action onPlayed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CDisplayVideoEval_003Ed__15))]
	private IEnumerator DisplayVideoEval(int views, Comment[] comments, CameraRecording recording)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayComment(Comment comment)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Replay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UploadCompleteUI()
	{
		throw null;
	}
}
