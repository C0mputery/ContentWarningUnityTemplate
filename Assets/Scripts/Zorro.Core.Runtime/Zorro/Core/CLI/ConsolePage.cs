using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

namespace Zorro.Core.CLI
{
	public class ConsolePage : DebugPage
	{
		private List<ConsoleLogEntry> m_logEntries;

		private DebugUIHandler m_debugUI;

		private VisualTreeAsset m_logEntryUXMLAsset;

		private VisualTreeAsset m_consoleUXMLAsset;

		private Optionable<byte> m_selectedSuggestion;

		private List<Label> m_suggestionsTexts;

		private List<Suggestion> m_suggestions;

		private int m_selectedHistory;

		private ListView m_listView;

		private int nextEntry;

		private Label m_entryLabel;

		private string m_currentInput;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsolePage(List<ConsoleLogEntry> logEntries, DebugUIHandler debugUI, VisualTreeAsset consoleUxmlAsset, VisualTreeAsset logEntryUxmlAsset)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConstructConsole(VisualElement root)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private VisualElement MakeLogEntry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BindEntry(VisualElement element, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetColoredText(string entryLog, string color)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FindSuggestions(string input)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AttemptParseCommand(string command)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogRecieved()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Suggestion GetNextSelectedSuggestion()
		{
			throw null;
		}
	}
}
