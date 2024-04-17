using System;
using System.Runtime.CompilerServices;

public struct LostFootageHandle : IComparable<LostFootageHandle>, IEquatable<LostFootageHandle>, IPlayableVideo
{
	public int index;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LostFootageHandle(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(LostFootageHandle other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(LostFootageHandle other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetVideoPath(out string path)
	{
		throw null;
	}
}
