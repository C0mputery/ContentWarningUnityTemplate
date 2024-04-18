using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class UnitySerializationInitializer
	{
		private static readonly object LOCK;

		private static bool initialized;

		public static bool Initialized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static RuntimePlatform CurrentPlatform
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
		public static void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void InitializeRuntime()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnitySerializationInitializer()
		{
		}
	}
}
