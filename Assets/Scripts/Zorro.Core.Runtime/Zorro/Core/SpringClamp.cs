using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public static class SpringClamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T BounceClamp<T>(T value, float min, float max, float energyConservation = 0.6f) where T : IOneDimension
		{
			throw null;
		}
	}
}
