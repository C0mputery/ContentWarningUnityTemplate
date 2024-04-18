using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class StateMachine<StateType> where StateType : StateMachineState
	{
		public StateType CurrentState;

		private Dictionary<Type, StateType> m_states;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterState(StateType state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T SwitchState<T>() where T : StateType
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StateType SwitchState(Type gamestateType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StateMachine()
		{

		}
	}
}
