using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class JsonDataReader : BaseDataReader
	{
		private JsonTextReader reader;

		private EntryType? peekedEntryType;

		private string peekedEntryName;

		private string peekedEntryContent;

		private Dictionary<int, Type> seenTypes;

		private readonly Dictionary<Type, Delegate> primitiveArrayReaders;

		public override Stream Stream
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonDataReader() : base(null, null)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonDataReader(Stream stream, DeserializationContext context) : base(stream, context)
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
		public override bool EnterNode(out Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ExitNode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool EnterArray(out long length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ExitArray()
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
		public override bool ReadInternalReference(out int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadExternalReference(out int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadExternalReference(out Guid guid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadExternalReference(out string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadChar(out char value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadString(out string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadGuid(out Guid value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadSByte(out sbyte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadInt16(out short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadInt32(out int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadInt64(out long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadByte(out byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadUInt16(out ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadUInt32(out uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadUInt64(out ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadDecimal(out decimal value)
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
		public override bool ReadNull()
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
		protected override EntryType PeekEntry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override EntryType ReadToNextEntry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarkEntryConsumed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ReadAnyIntReference(out int value)
		{
			throw null;
		}
	}
}
