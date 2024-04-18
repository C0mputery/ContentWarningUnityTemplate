using System.Runtime.CompilerServices;

namespace pworld.Scripts.Extensions
{
	public class NullAfterTime<T> where T : class
	{
		private readonly float timeToNull;

		private bool paused;

		private float pausedStart;

		private T t;

		private float timePaused;

		private float timeWhenSet;

		public T Value
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

		public bool Paused
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NullAfterTime(float timeToNull_ = 0.5f)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetTimer()
		{
			throw null;
		}
	}
}
