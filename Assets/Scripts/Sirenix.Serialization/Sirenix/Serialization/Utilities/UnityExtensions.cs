using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization.Utilities
{
	internal static class UnityExtensions
	{
		private static readonly ValueGetter<UnityEngine.Object, IntPtr> UnityObjectCachedPtrFieldGetter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnityExtensions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SafeIsUnityNull(this UnityEngine.Object obj)
		{
			throw null;
		}
	}
}
