using System;

namespace Sirenix.Serialization
{
	public interface ILogger
	{
		void LogWarning(string warning);

		void LogError(string error);

		void LogException(Exception exception);
	}
}
