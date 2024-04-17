using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.UI
{
	public class UIPageHandler : MonoBehaviour
	{
		public UIPage currentPage;

		private Dictionary<Type, UIPage> _pages;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T TransistionToPage<T>() where T : UIPage
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPage TransistionToPage(UIPage page, PageTransistion pageTransistion)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnTransistionedToPage(UIPage newPage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPageHandler()
		{
			throw null;
		}
	}
}
