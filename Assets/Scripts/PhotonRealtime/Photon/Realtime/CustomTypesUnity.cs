using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	internal static class CustomTypesUnity
	{
		private const int SizeV2 = 8;

		private const int SizeV3 = 12;

		private const int SizeQuat = 16;

		public static readonly byte[] memVector3;

		public static readonly byte[] memVector2;

		public static readonly byte[] memQuarternion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Register()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static short SerializeVector3(StreamBuffer outStream, object customobject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object DeserializeVector3(StreamBuffer inStream, short length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static short SerializeVector2(StreamBuffer outStream, object customobject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object DeserializeVector2(StreamBuffer inStream, short length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static short SerializeQuaternion(StreamBuffer outStream, object customobject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object DeserializeQuaternion(StreamBuffer inStream, short length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CustomTypesUnity()
		{
			throw null;
		}
	}
}
