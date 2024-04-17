using System;
using System.Runtime.CompilerServices;

public struct ClipID : IComparable<ClipID>, IEquatable<ClipID>
{
	public Guid id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClipID(Guid id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(ClipID other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(ClipID other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToShortString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToMiniString()
	{
		throw null;
	}
}
