using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.Splines;

namespace pworld.Scripts.Extensions
{
	public static class PExtSpline
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static NativeSpline PGetNative(this Spline me, Allocator allocator = Allocator.TempJob)
		{
			throw null;
		}
	}
}
