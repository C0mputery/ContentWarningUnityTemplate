using System;
using System.Runtime.CompilerServices;

namespace pworld.Scripts.Extensions
{
	[Serializable]
	public class PHourGlass
	{
		public float timeToFill;

		private float startTime;

		public bool Filled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PHourGlass(float timeToFill)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Flip(float newTimeToFill = -1f)
		{
			throw null;
		}
	}
}
