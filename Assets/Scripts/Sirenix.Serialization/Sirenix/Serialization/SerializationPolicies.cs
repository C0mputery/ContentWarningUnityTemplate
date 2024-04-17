using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public static class SerializationPolicies
	{
		private static readonly object LOCK;

		private static volatile ISerializationPolicy everythingPolicy;

		private static volatile ISerializationPolicy unityPolicy;

		private static volatile ISerializationPolicy strictPolicy;

		public static ISerializationPolicy Everything
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static ISerializationPolicy Unity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static ISerializationPolicy Strict
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryGetByID(string name, out ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SerializationPolicies()
		{
			throw null;
		}
	}
}
