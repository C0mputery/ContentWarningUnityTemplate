using System;
using System.Runtime.CompilerServices;

namespace pworld.Scripts.PPID
{
	[Serializable]
	public class PPID
	{
		public float p;

		public float i;

		public float d;

		private float prevError;

		private float proportion;

		private float integral;

		private float derivative;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValues(float p, float i, float d)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetOutput(float currentError, float dt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PPID()
		{
			throw null;
		}
	}
}
