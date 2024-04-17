using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class JsonDataWriter : BaseDataWriter
	{
		private static readonly uint[] ByteToHexCharLookup;

		private static readonly string NEW_LINE;

		private bool justStarted;

		private bool forceNoSeparatorNextLine;

		private Dictionary<Type, Delegate> primitiveTypeWriters;

		private Dictionary<Type, int> seenTypes;

		private byte[] buffer;

		private int bufferIndex;

		public bool FormatAsReadable;

		public bool EnableTypeOptimization;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonDataWriter() : this(null, null, true)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonDataWriter(Stream stream, SerializationContext context, bool formatAsReadable = true) : base(null, null)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MarkJustStarted()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FlushToStream()
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
		public override void EndNode(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeginArrayNode(long length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void EndArrayNode()
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
		public override void WriteGuid(string name, Guid value)
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
		public override void WriteExternalReference(string name, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteExternalReference(string name, Guid guid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteExternalReference(string name, string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteUInt16(string name, ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteEntry(string name, string contents)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteEntry(string name, string contents, char surroundContentsWith)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteTypeEntry(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartNewLine(bool noSeparator = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnsureBufferSpace(int space)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Buffer_WriteString_WithEscape(string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static uint[] CreateByteToHexLookup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonDataWriter()
		{
			throw null;
		}
	}
}
