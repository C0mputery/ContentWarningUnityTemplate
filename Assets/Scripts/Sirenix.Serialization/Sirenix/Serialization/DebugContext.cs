using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class DebugContext
	{
		private readonly object LOCK;

		private volatile ILogger logger;

		private volatile LoggingPolicy loggingPolicy;

		private volatile ErrorHandlingPolicy errorHandlingPolicy;

		public ILogger Logger
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

		public LoggingPolicy LoggingPolicy
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

		public ErrorHandlingPolicy ErrorHandlingPolicy
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
		public void LogWarning(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogError(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogException(Exception exception)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetToDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugContext()
		{

		}
	}
}
