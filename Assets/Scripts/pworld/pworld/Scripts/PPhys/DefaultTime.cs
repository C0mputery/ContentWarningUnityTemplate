using System.Runtime.CompilerServices;

namespace pworld.Scripts.PPhys
{
	public class DefaultTime : ITimeSource
	{
		private static float previousTimeScale;

		public float TimeScale
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public float DeltaTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GoToPreviousTimeScale()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DefaultTime()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DefaultTime()
		{
			throw null;
		}
	}
}
