using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Sirenix.Serialization
{
	public static class ProperBitConverter
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct SingleByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(0)]
			public float Value;
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct DoubleByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;

			[FieldOffset(0)]
			public double Value;
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct DecimalByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;

			[FieldOffset(8)]
			public byte Byte8;

			[FieldOffset(9)]
			public byte Byte9;

			[FieldOffset(10)]
			public byte Byte10;

			[FieldOffset(11)]
			public byte Byte11;

			[FieldOffset(12)]
			public byte Byte12;

			[FieldOffset(13)]
			public byte Byte13;

			[FieldOffset(14)]
			public byte Byte14;

			[FieldOffset(15)]
			public byte Byte15;

			[FieldOffset(0)]
			public decimal Value;
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct GuidByteUnion
		{
			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;

			[FieldOffset(8)]
			public byte Byte8;

			[FieldOffset(9)]
			public byte Byte9;

			[FieldOffset(10)]
			public byte Byte10;

			[FieldOffset(11)]
			public byte Byte11;

			[FieldOffset(12)]
			public byte Byte12;

			[FieldOffset(13)]
			public byte Byte13;

			[FieldOffset(14)]
			public byte Byte14;

			[FieldOffset(15)]
			public byte Byte15;

			[FieldOffset(0)]
			public Guid Value;
		}

		private static readonly uint[] ByteToHexCharLookupLowerCase;

		private static readonly uint[] ByteToHexCharLookupUpperCase;

		private static readonly byte[] HexToByteLookup;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static uint[] CreateByteToHexLookup(bool upperCase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string BytesToHexString(byte[] bytes, bool lowerCaseHexChars = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] HexStringToBytes(string hex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static short ToInt16(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ushort ToUInt16(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ToInt32(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static uint ToUInt32(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long ToInt64(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ulong ToUInt64(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float ToSingle(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static double ToDouble(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal ToDecimal(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Guid ToGuid(byte[] buffer, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, double value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, decimal value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetBytes(byte[] buffer, int index, Guid value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ProperBitConverter()
		{
			throw null;
		}
	}
}
