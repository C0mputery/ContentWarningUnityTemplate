using System.Runtime.CompilerServices;
using Zorro.Core.CLI;

public class Monster
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void KillAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void SpawnMonster(string monster)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monster()
	{
		throw null;
	}
}
