using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class RegionPinger
	{
		[CompilerGenerated]
		private sealed class _003CRegionPingCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RegionPinger _003C_003E4__this;

			private int _003CrttSum_003E5__2;

			private int _003CreplyCount_003E5__3;

			private Stopwatch _003Csw_003E5__4;

			private int _003Ci_003E5__5;

			object IEnumerator<object>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003CRegionPingCoroutine_003Ed__22(int _003C_003E1__state)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				throw null;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		public static int Attempts;

		public static int MaxMillisecondsPerPing;

		public static int PingWhenFailed;

		public int CurrentAttempt;

		private Action<Region> onDoneCall;

		private PhotonPing ping;

		private List<int> rttResults;

		private Region region;

		private string regionAddress;

		public bool Done
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

		public bool Aborted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegionPinger(Region region, Action<Region> onDoneCallback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private PhotonPing GetPingImplementation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void Abort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal bool RegionPingThreaded()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CRegionPingCoroutine_003Ed__22))]
		protected internal IEnumerator RegionPingCoroutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetResults()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ResolveHost(string hostName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RegionPinger()
		{
			throw null;
		}
	}
}
