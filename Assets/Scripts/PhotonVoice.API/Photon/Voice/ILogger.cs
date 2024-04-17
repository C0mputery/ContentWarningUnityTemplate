namespace Photon.Voice
{
	public interface ILogger
	{
		void LogError(string fmt, params object[] args);

		void LogWarning(string fmt, params object[] args);

		void LogInfo(string fmt, params object[] args);

		void LogDebug(string fmt, params object[] args);
	}
}
