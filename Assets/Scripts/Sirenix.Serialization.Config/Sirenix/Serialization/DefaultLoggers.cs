using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public static class DefaultLoggers
	{
		private static readonly object LOCK;

		private static volatile ILogger unityLogger;

		public static ILogger DefaultLogger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static ILogger UnityLogger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DefaultLoggers()
		{
			throw null;
		}
	}
}
