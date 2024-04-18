using System.Runtime.CompilerServices;
using Zorro.Core;

public abstract class VideoExtractMachineState : StateMachineState
{
	public ExtractVideoMachine Machine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoExtractMachineState(ExtractVideoMachine machine)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		throw null;
	}
}
