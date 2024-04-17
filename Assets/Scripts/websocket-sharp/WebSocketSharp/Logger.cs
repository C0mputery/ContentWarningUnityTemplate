using System;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	public class Logger
	{
		private volatile string _file;

		private volatile LogLevel _level;

		private Action<LogData, string> _output;

		private object _sync;

		public string File
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public LogLevel Level
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Action<LogData, string> Output
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Logger()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Logger(LogLevel level)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Logger(LogLevel level, string file, Action<LogData, string> output)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void defaultOutput(LogData data, string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void output(string message, LogLevel level)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void writeToFile(string value, string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Debug(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Error(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Fatal(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Info(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Trace(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Warn(string message)
		{
			throw null;
		}
	}
}
