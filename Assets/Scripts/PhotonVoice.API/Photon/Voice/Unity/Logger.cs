using System.Runtime.CompilerServices;

namespace Photon.Voice.Unity
{
	public class Logger : ILogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogError(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogWarning(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogInfo(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogDebug(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Logger()
		{

		}
	}
}
