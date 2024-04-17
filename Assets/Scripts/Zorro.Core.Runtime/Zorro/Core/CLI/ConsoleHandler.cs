using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core.CLI
{
	public static class ConsoleHandler
	{
		private static ConsoleCommand[] m_consoleCommands;

		private static bool m_loaded;

		private static List<string> m_typedHistory;

		public const string TEXT_COLOR_HEX = "#cccaca";

		public const string HIGHLIGHTED_COLOR_HEX = "#ffffff";

		public const string ERROR_COLOR_HEX = "#fc5347";

		public const string TEXT_COLOR = "<color=#cccaca>";

		public const string HIGHLIGHTED_COLOR = "<color=#ffffff>";

		public const string ERROR_COLOR = "<color=#fc5347>";

		private static Dictionary<Type, CLITypeParser> m_typeParsers;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ProcessCommand(string command)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object ConvertParameter(string parameter, Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<Suggestion> FindSuggestions(string input)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddToHistory(string command)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<string> GetHistory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConsoleHandler()
		{
			throw null;
		}
	}
}
