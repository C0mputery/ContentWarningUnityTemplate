using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class StateMachineState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Enter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Exit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StateMachineState()
		{
			throw null;
		}
	}
}
