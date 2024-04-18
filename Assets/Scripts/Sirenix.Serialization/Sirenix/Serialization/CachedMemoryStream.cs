using System.IO;
using System.Runtime.CompilerServices;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	internal sealed class CachedMemoryStream : ICacheNotificationReceiver
	{
		public static int InitialCapacity;

		public static int MaxCapacity;

		private MemoryStream memoryStream;

		public MemoryStream MemoryStream
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CachedMemoryStream()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnFreed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClaimed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Cache<CachedMemoryStream> Claim(int minCapacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Cache<CachedMemoryStream> Claim(byte[] bytes = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CachedMemoryStream()
		{
			throw null;
		}
	}
}
