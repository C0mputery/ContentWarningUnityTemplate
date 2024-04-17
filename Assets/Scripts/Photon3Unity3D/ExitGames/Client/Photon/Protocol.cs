using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class Protocol
	{
		internal static readonly Dictionary<Type, CustomType> TypeDict;

		internal static readonly Dictionary<byte, CustomType> CodeDict;

		private static IProtocol ProtocolDefault;

		private static readonly float[] memFloatBlock;

		private static readonly byte[] memDeserialize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryRegisterType(Type type, byte typeCode, SerializeMethod serializeFunction, DeserializeMethod deserializeFunction)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryRegisterType(Type type, byte typeCode, SerializeStreamMethod serializeFunction, DeserializeStreamMethod deserializeFunction)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		public static byte[] Serialize(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		public static object Deserialize(byte[] serializedData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Serialize(short value, byte[] target, ref int targetOffset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Serialize(int value, byte[] target, ref int targetOffset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Serialize(float value, byte[] target, ref int targetOffset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Deserialize(out int value, byte[] source, ref int offset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Deserialize(out short value, byte[] source, ref int offset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Deserialize(out float value, byte[] source, ref int offset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Protocol()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Protocol()
		{
			throw null;
		}
	}
}
