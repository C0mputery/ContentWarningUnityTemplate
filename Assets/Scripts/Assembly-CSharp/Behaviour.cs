using System;
using System.Runtime.CompilerServices;

[Serializable]
public class Behaviour
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Behaviour()
	{

	}
}
