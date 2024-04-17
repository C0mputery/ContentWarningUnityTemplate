using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

namespace Zorro.UI
{
	public class GameUI : Singleton<GameUI>
	{
		public OverlayUIHandler overlayUI;

		private Dictionary<Type, GameUISystem> m_gameUISystems;

		private Dictionary<Type, GameUISystem> m_nonCustomGameUISystems;

		public List<GameUISystem> OpenSystems;

		private bool m_shouldShowCursor;

		private CanvasGroup m_canvasGroup;

		private bool m_show;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RegisterSystem(GameUISystem system)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnregisterSystem(GameUISystem system)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RunUICode<T>(Action<T> codeAction) where T : GameUISystem
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NeedsCursor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetFadeVisibility(bool show)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowUI<T>() where T : GameUISystem
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowUI<T>(Action<T> codeAction) where T : GameUISystem
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowUI(Type systemType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Hide(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Hide<T>() where T : GameUISystem
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RecalculateShouldShowCursor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool ShouldAttemptOpenMenu()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool EscapeMenuOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<Type, GameUISystem> GetUISystems()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameUI()
		{
			throw null;
		}
	}
}
