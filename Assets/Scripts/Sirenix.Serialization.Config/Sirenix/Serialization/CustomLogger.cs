using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class CustomLogger : ILogger
	{
		private Action<string> logWarningDelegate;

		private Action<string> logErrorDelegate;

		private Action<Exception> logExceptionDelegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomLogger(Action<string> logWarningDelegate, Action<string> logErrorDelegate, Action<Exception> logExceptionDelegate)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogWarning(string warning)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogError(string error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogException(Exception exception)
		{
			throw null;
		}
	}
}
