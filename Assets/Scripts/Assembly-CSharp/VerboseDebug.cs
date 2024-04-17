using System.Runtime.CompilerServices;

public static class VerboseDebug
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(string message)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LogError(string s)
	{
		throw null;
	}
}
