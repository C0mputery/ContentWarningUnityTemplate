using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class Protocol16 : IProtocol
	{
		public enum GpType : byte
		{
			Unknown = 0,
			Array = 121,
			Boolean = 111,
			Byte = 98,
			ByteArray = 120,
			ObjectArray = 122,
			Short = 107,
			Float = 102,
			Dictionary = 68,
			Double = 100,
			Hashtable = 104,
			Integer = 105,
			IntegerArray = 110,
			Long = 108,
			String = 115,
			StringArray = 97,
			Custom = 99,
			Null = 42,
			EventData = 101,
			OperationRequest = 113,
			OperationResponse = 112
		}

		private readonly byte[] versionBytes;

		private readonly byte[] memShort;

		private readonly long[] memLongBlock;

		private readonly byte[] memLongBlockBytes;

		private static readonly float[] memFloatBlock;

		private static readonly byte[] memFloatBlockBytes;

		private readonly double[] memDoubleBlock;

		private readonly byte[] memDoubleBlockBytes;

		private readonly byte[] memInteger;

		private readonly byte[] memLong;

		private readonly byte[] memFloat;

		private readonly byte[] memDouble;

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
		private bool SerializeCustom(StreamBuffer dout, object serObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object DeserializeCustom(StreamBuffer din, byte customTypeCode, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type GetTypeOfCode(byte typeCode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private GpType GetCodeOfType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Array CreateArrayByType(byte arrayType, short length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SerializeOperationRequest(StreamBuffer stream, OperationRequest operation, bool setType)
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
		public override OperationRequest DeserializeOperationRequest(StreamBuffer din, DeserializationFlags flags)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override OperationResponse DeserializeOperationResponse(StreamBuffer stream, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use ParameterDictionary instead of Dictionary<byte, object>.")]
		private void SerializeParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeParameterTable(StreamBuffer stream, ParameterDictionary parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Dictionary<byte, object> DeserializeParameterTable(StreamBuffer stream, Dictionary<byte, object> target = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ParameterDictionary DeserializeParameterDictionary(StreamBuffer stream, ParameterDictionary target = null, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(StreamBuffer dout, object serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeByte(StreamBuffer dout, byte serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeBoolean(StreamBuffer dout, bool serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeShort(StreamBuffer dout, short serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SerializeLengthAsShort(StreamBuffer dout, int serObject, string type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeInteger(StreamBuffer dout, int serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeLong(StreamBuffer dout, long serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeFloat(StreamBuffer dout, float serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeDouble(StreamBuffer dout, double serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SerializeString(StreamBuffer stream, string value, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeArray(StreamBuffer dout, Array serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeByteArray(StreamBuffer dout, byte[] serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeByteArraySegment(StreamBuffer dout, byte[] serObject, int offset, int count, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeIntArrayOptimized(StreamBuffer inWriter, int[] serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeStringArray(StreamBuffer dout, string[] serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeObjectArray(StreamBuffer dout, IList objects, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeHashTable(StreamBuffer dout, Hashtable serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeDictionary(StreamBuffer dout, IDictionary serObject, bool setType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeDictionaryHeader(StreamBuffer writer, Type dictType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeDictionaryHeader(StreamBuffer writer, object dict, out bool setKeyType, out bool setValueType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeDictionaryElements(StreamBuffer writer, object dict, bool setKeyType, bool setValueType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object Deserialize(StreamBuffer din, byte type, DeserializationFlags flags = DeserializationFlags.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override byte DeserializeByte(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeBoolean(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override short DeserializeShort(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int DeserializeInteger(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private long DeserializeLong(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float DeserializeFloat(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private double DeserializeDouble(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string DeserializeString(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Array DeserializeArray(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] DeserializeByteArray(StreamBuffer din, int size = -1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int[] DeserializeIntArray(StreamBuffer din, int size = -1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] DeserializeStringArray(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object[] DeserializeObjectArray(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Hashtable DeserializeHashTable(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IDictionary DeserializeDictionary(StreamBuffer din)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeDictionaryArray(StreamBuffer din, short size, out Array arrayResult)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type DeserializeDictionaryType(StreamBuffer reader, out byte keyTypeCode, out byte valTypeCode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Protocol16()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Protocol16()
		{
			throw null;
		}
	}
}
