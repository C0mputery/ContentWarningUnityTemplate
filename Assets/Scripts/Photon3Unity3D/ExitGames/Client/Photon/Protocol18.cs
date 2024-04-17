using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon.StructWrapping;

namespace ExitGames.Client.Photon
{
	public class Protocol18 : IProtocol
	{
		public enum GpType : byte
		{
			Unknown = 0,
			Boolean = 2,
			Byte = 3,
			Short = 4,
			Float = 5,
			Double = 6,
			String = 7,
			Null = 8,
			CompressedInt = 9,
			CompressedLong = 10,
			Int1 = 11,
			Int1_ = 12,
			Int2 = 13,
			Int2_ = 14,
			L1 = 15,
			L1_ = 16,
			L2 = 17,
			L2_ = 18,
			Custom = 19,
			CustomTypeSlim = 128,
			Dictionary = 20,
			Hashtable = 21,
			ObjectArray = 23,
			OperationRequest = 24,
			OperationResponse = 25,
			EventData = 26,
			BooleanFalse = 27,
			BooleanTrue = 28,
			ShortZero = 29,
			IntZero = 30,
			LongZero = 31,
			FloatZero = 32,
			DoubleZero = 33,
			ByteZero = 34,
			Array = 64,
			BooleanArray = 66,
			ByteArray = 67,
			ShortArray = 68,
			DoubleArray = 70,
			FloatArray = 69,
			StringArray = 71,
			HashtableArray = 85,
			DictionaryArray = 84,
			CustomTypeArray = 83,
			CompressedIntArray = 73,
			CompressedLongArray = 74
		}

		private readonly byte[] versionBytes;

		private static readonly byte[] boolMasks;

		private readonly double[] memDoubleBlock;

		private readonly float[] memFloatBlock;

		private readonly byte[] memCustomTypeBodyLengthSerialized;

		private readonly byte[] memCompressedUInt32;

		private byte[] memCompressedUInt64;

		public override string ProtocolType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override byte[] VersionBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(StreamBuffer dout, object serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeShort(StreamBuffer dout, short serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeString(StreamBuffer dout, string serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object Deserialize(StreamBuffer din, byte type, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override short DeserializeShort(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override byte DeserializeByte(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Type GetAllowedDictionaryKeyTypes(GpType gpType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Type GetClrArrayType(GpType gpType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private GpType GetCodeOfType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private GpType GetCodeOfTypeCode(TypeCode type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object Read(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object Read(StreamBuffer stream, byte gpType, DeserializationFlags flags = DeserializationFlags.None, ParameterDictionary parameters = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ReadBoolean(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte ReadByte(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal short ReadInt16(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ushort ReadUShort(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int ReadInt32(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long ReadInt64(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float ReadSingle(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal double ReadDouble(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ByteArraySlice ReadNonAllocByteArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] ReadByteArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ReadCustomType(StreamBuffer stream, byte gpType = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use ParameterDictionary instead.")]
		private Dictionary<byte, object> ReadParameterTable(StreamBuffer stream, Dictionary<byte, object> target = null, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ParameterDictionary ReadParameterDictionary(StreamBuffer stream, ParameterDictionary target = null, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Hashtable ReadHashtable(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int[] ReadIntArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override OperationRequest DeserializeOperationRequest(StreamBuffer din, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override OperationResponse DeserializeOperationResponse(StreamBuffer stream, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string ReadString(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ReadCustomTypeArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type ReadDictionaryType(StreamBuffer stream, out GpType keyReadType, out GpType valueReadType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type ReadDictionaryType(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type GetDictArrayType(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IDictionary ReadDictionary(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ReadDictionaryElements(StreamBuffer stream, GpType keyReadType, GpType valueReadType, IDictionary dictionary, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object[] ReadObjectArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private StructWrapper[] ReadWrapperArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool[] ReadBooleanArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal short[] ReadInt16Array(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float[] ReadSingleArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private double[] ReadDoubleArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string[] ReadStringArray(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Hashtable[] ReadHashtableArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IDictionary[] ReadDictionaryArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Array ReadArrayInArray(StreamBuffer stream, DeserializationFlags flags, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int ReadInt1(StreamBuffer stream, bool signNegative)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int ReadInt2(StreamBuffer stream, bool signNegative)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int ReadCompressedInt32(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint ReadCompressedUInt32(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long ReadCompressedInt64(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ulong ReadCompressedUInt64(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int[] ReadCompressedInt32Array(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long[] ReadCompressedInt64Array(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int DecodeZigZag32(uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private long DecodeZigZag64(ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Write(StreamBuffer stream, object value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Write(StreamBuffer stream, object value, GpType gpType, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteParameterTable(StreamBuffer stream, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeOperationRequest(StreamBuffer stream, OperationRequest operation, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use ParameterDictionary instead.")]
		public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, ParameterDictionary parameters, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteByte(StreamBuffer stream, byte value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteBoolean(StreamBuffer stream, bool value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteUShort(StreamBuffer stream, ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteInt16(StreamBuffer stream, short value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteDouble(StreamBuffer stream, double value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteSingle(StreamBuffer stream, float value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteString(StreamBuffer stream, string value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteHashtable(StreamBuffer stream, object value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteByteArray(StreamBuffer stream, byte[] value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteArraySegmentByte(StreamBuffer stream, ArraySegment<byte> seg, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteByteArraySlice(StreamBuffer stream, ByteArraySlice buffer, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteInt32ArrayCompressed(StreamBuffer stream, int[] value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteInt64ArrayCompressed(StreamBuffer stream, long[] values, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteBoolArray(StreamBuffer stream, bool[] value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteInt16Array(StreamBuffer stream, short[] value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteSingleArray(StreamBuffer stream, float[] values, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteDoubleArray(StreamBuffer stream, double[] values, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteStringArray(StreamBuffer stream, object value0, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteObjectArray(StreamBuffer stream, object array, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteObjectArray(StreamBuffer stream, IList array, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteArrayInArray(StreamBuffer stream, object value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCustomTypeBody(CustomType customType, StreamBuffer stream, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCustomType(StreamBuffer stream, object value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCustomTypeArray(StreamBuffer stream, object value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool WriteArrayHeader(StreamBuffer stream, Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteDictionaryElements(StreamBuffer stream, IDictionary dictionary, GpType keyWriteType, GpType valueWriteType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteDictionary(StreamBuffer stream, object dict, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteDictionaryHeader(StreamBuffer stream, Type type, out GpType keyWriteType, out GpType valueWriteType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool WriteArrayType(StreamBuffer stream, Type type, out GpType writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteHashtableArray(StreamBuffer stream, object value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteDictionaryArray(StreamBuffer stream, IDictionary[] dictArray, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteIntLength(StreamBuffer stream, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteVarInt32(StreamBuffer stream, int value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCompressedInt32(StreamBuffer stream, int value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCompressedInt64(StreamBuffer stream, long value, bool writeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCompressedUInt32(StreamBuffer stream, uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int WriteCompressedUInt32(byte[] buffer, uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCompressedUInt64(StreamBuffer stream, ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint EncodeZigZag32(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ulong EncodeZigZag64(long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Protocol18()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Protocol18()
		{
			throw null;
		}
	}
}
