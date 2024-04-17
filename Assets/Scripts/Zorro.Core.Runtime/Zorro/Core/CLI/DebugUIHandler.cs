using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

namespace Zorro.Core.CLI
{
	public class DebugUIHandler : Singleton<DebugUIHandler>
	{
		public VisualTreeAsset m_consoleUXMLAsset;

		public VisualTreeAsset m_logEntryUXMLAsset;

		private VisualElement m_contentRoot;

		private UIDocument m_document;

		private List<ConsoleLogEntry> m_logEntries;

		private DebugPage m_currentPage;

		private List<Button> m_pageButtons;

		private VisualElement m_toolbar;

		private List<(string, Func<DebugPage>)> m_customPages;

		private HashSet<string> m_uniquePages;

		public DebugPage CurrentPage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsOpen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterPage(string text, Func<DebugPage> page)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ApplicationOnlogMessageReceived(string condition, string stacktrace, LogType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEntry(ConsoleLogEntry entry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BuildToolbar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GoToConsole()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenPage(DebugPage page)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugUIHandler()
		{
			throw null;
		}
	}
}
