using System.Runtime.CompilerServices;

public class WeepingContentEventFail : MonsterContentEvent
{
	public static string[] FAIL_COMMENTS;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float GetContentValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ushort GetID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Comment GenerateComment()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WeepingContentEventFail()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WeepingContentEventFail()
	{
		throw null;
	}
}
