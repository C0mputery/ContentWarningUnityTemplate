using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace pworld.Scripts.PUpdate
{
	public static class PUpdate
	{
		private static readonly HashSet<IPPreUpdate> _earlyUpdates;

		private static readonly HashSet<IPPostLateUpdate> _superLateUpdates;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RegisterPreUpdate(IPPreUpdate _IPPreUpdate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RegisterSuperLateUpdate(IPPostLateUpdate _ipPostLateUpdate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnregisterPreUpdate(IPPreUpdate _IPPreUpdate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnregisterSuperLateUpdate(IPPostLateUpdate _ipPostLateUpdate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnEarlyUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnSuperLateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PUpdate()
		{
			throw null;
		}
	}
}
