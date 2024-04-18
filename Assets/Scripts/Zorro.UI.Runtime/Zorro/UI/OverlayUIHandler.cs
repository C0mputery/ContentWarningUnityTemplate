using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Zorro.UI
{
	public class OverlayUIHandler : UIPageHandler
	{
		[SerializeField]
		private UIPage m_mainPage;

		[SerializeField]
		private Button m_closeUIButton;

		private bool shouldBeOpen;

		public bool IsOpen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnTransistionedToPage(UIPage newPage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OverlayUIHandler()
		{

		}
	}
}
