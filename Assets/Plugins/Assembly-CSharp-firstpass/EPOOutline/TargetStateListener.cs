using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline
{
	[ExecuteAlways]
	public class TargetStateListener : MonoBehaviour
	{
		public struct Callback
		{
			public readonly Outlinable Target;

			public readonly Action Action;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Callback(Outlinable target, Action action)
			{
				throw null;
			}
		}

		private List<Callback> callbacks;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCallback(Outlinable outlinable, Action action)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveCallback(Outlinable outlinable, Action callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameVisible()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameInvisible()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TargetStateListener()
		{
			throw null;
		}
	}
}
