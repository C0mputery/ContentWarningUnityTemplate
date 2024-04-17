using System;
using System.Runtime.CompilerServices;
using Zorro.Core;

public static class ObjectiveDatabase
{
	private static bool m_isInitialized;

	private static BidirectionalDictionary<byte, Type> types;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Initialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte GetIndex(Type type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte GetIndex(Objective objective)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(byte key)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Objective GetObjectiveInstance(byte index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetObjectiveInstance<T>() where T : Objective
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasObjectiveBeenCompleted(Objective objective)
	{
		throw null;
	}
}
