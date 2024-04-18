using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class BinaryDataReader : BaseDataReader
	{
		private struct Struct256Bit
		{
			public decimal d1;

			public decimal d2;
		}

		private static readonly Dictionary<Type, Delegate> PrimitiveFromByteMethods;

		private byte[] internalBufferBackup;

		private byte[] buffer;

		private int bufferIndex;

		private int bufferEnd;

		private EntryType? peekedEntryType;

		private BinaryEntryType peekedBinaryEntryType;

		private string peekedEntryName;

		private Dictionary<int, Type> types;

		/*[MethodImpl(MethodImplOptions.NoInlining)]
		public BinaryDataReader() 
		{

        }*/

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinaryDataReader(Stream stream, DeserializationContext context) : base(stream, context)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EntryType PeekEntry(out string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool EnterArray(out long length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool EnterNode(out Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ExitArray()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ExitNode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadPrimitiveArray<T>(out T[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadBoolean(out bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadSByte(out sbyte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadByte(out byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadInt16(out short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadUInt16(out ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadInt32(out int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadUInt32(out uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadInt64(out long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadUInt64(out ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadChar(out char value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadSingle(out float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadDouble(out double value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadDecimal(out decimal value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadExternalReference(out Guid guid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadGuid(out Guid value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadExternalReference(out int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadExternalReference(out string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadNull()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadInternalReference(out int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadString(out string value)
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
		private string ReadStringValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void SkipStringValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SkipPeekedEntryContent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool SkipBuffer(int amount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private Type ReadTypeEntry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private void MarkEntryContentConsumed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override EntryType PeekEntry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override EntryType ReadToNextEntry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_1_Byte(out byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_1_SByte(out sbyte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_2_Int16(out short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_2_UInt16(out ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_2_Char(out char value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_4_Int32(out int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_4_UInt32(out uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_4_Float32(out float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_8_Int64(out long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_8_UInt64(out ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_8_Float64(out double value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_16_Decimal(out decimal value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool UNSAFE_Read_16_Guid(out Guid value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		private bool HasBufferData(int amount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadEntireStreamToBuffer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BinaryDataReader()
		{
			throw null;
		}
	}
}
