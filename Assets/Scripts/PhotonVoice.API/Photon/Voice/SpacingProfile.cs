using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class SpacingProfile
	{
		private short[] buf;

		private bool[] info;

		private int capacity;

		private int ptr;

		private Stopwatch watch;

		private long watchLast;

		private bool flushed;

		public string Dump
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Max
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpacingProfile(int capacity)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(bool lost, bool flush)
		{
			throw null;
		}
	}
}
