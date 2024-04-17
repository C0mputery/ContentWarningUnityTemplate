using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal class SimulationItem
	{
		internal readonly Stopwatch stopw;

		public int TimeToExecute;

		public byte[] DelayedData;

		public int Delay
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
		public SimulationItem()
		{
			throw null;
		}
	}
}
