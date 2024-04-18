using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class BinaryDataWriter : BaseDataWriter
	{
		private struct Struct256Bit
		{
			public decimal d1;

			public decimal d2;
		}

		private static readonly Dictionary<Type, Delegate> PrimitiveGetBytesMethods;

		private static readonly Dictionary<Type, int> PrimitiveSizes;

		private readonly byte[] small_buffer;

		private readonly byte[] buffer;

		private int bufferIndex;

		private readonly Dictionary<Type, int> types;

		public bool CompressStringsTo8BitWhenPossible;

		private static readonly Dictionary<Type, Action<BinaryDataWriter, object>> PrimitiveArrayWriters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinaryDataWriter() : base(null, null)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinaryDataWriter(Stream stream, SerializationContext context) : base(null, null)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeginArrayNode(long length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeginReferenceNode(string name, Type type, int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeginStructNode(string name, Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void EndArrayNode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void EndNode(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_byte(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_sbyte(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_bool(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_char(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_short(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_int(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_long(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_ushort(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_uint(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_ulong(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_decimal(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_float(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_double(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WritePrimitiveArray_Guid(BinaryDataWriter writer, object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WritePrimitiveArray<T>(T[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteBoolean(string name, bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteByte(string name, byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteChar(string name, char value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteDecimal(string name, decimal value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteDouble(string name, double value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteGuid(string name, Guid value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteExternalReference(string name, Guid guid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteExternalReference(string name, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteExternalReference(string name, string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteInt32(string name, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteInt64(string name, long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteNull(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteInternalReference(string name, int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteSByte(string name, sbyte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteInt16(string name, short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteSingle(string name, float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteString(string name, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteUInt32(string name, uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteUInt64(string name, ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteUInt16(string name, ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PrepareNewSerializationSession()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetDataDump()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void WriteType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteStringFast(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FlushToStream()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void UNSAFE_WriteToBuffer_2_Char(char value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void UNSAFE_WriteToBuffer_2_Int16(short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void UNSAFE_WriteToBuffer_2_UInt16(ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void UNSAFE_WriteToBuffer_4_Int32(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void UNSAFE_WriteToBuffer_4_UInt32(uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void UNSAFE_WriteToBuffer_4_Float32(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UNSAFE_WriteToBuffer_8_Int64(long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UNSAFE_WriteToBuffer_8_UInt64(ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UNSAFE_WriteToBuffer_8_Float64(double value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UNSAFE_WriteToBuffer_16_Decimal(decimal value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UNSAFE_WriteToBuffer_16_Guid(Guid value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void EnsureBufferSpace(int space)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool TryEnsureBufferSpace(int space)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BinaryDataWriter()
		{
			throw null;
		}
	}
}
