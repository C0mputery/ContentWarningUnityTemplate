using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class RegionHandler
	{
		public static Type PingImplementation;

		private string availableRegionCodes;

		private Region bestRegionCache;

		private readonly List<RegionPinger> pingerList;

		private Action<RegionHandler> onCompleteCall;

		private int previousPing;

		private string previousSummaryProvided;

		protected internal static ushort PortToPingOverride;

		public int BestRegionSummaryPingLimit;

		private MonoBehaviourEmpty emptyMonoBehavior;

		public List<Region> EnabledRegions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected internal set
			{
				throw null;
			}
		}

		public Region BestRegion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string SummaryToCache
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsPinging
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
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetResults()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRegions(OperationResponse opGetRegions)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegionHandler(ushort masterServerPortOverride = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PingMinimumOfRegions(Action<RegionHandler> onCompleteCallback, string previousSummary)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Abort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPreferredRegionPinged(Region preferredRegion)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PingEnabledRegions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRegionDone(Region region)
		{
			throw null;
		}
	}
}
