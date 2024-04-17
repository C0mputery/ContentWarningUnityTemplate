using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class BaseDataReader : BaseDataReaderWriter, IDataReader, IDisposable
	{
		private DeserializationContext context;

		private Stream stream;

		public int CurrentNodeId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int CurrentNodeDepth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string CurrentNodeName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual Stream Stream
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

		public DeserializationContext Context
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
		protected BaseDataReader(Stream stream, DeserializationContext context)
		{
			throw null;
		}

		public abstract bool EnterNode(out Type type);

		public abstract bool ExitNode();

		public abstract bool EnterArray(out long length);

		public abstract bool ExitArray();

		public abstract bool ReadPrimitiveArray<T>(out T[] array) where T : struct;

		public abstract EntryType PeekEntry(out string name);

		public abstract bool ReadInternalReference(out int id);

		public abstract bool ReadExternalReference(out int index);

		public abstract bool ReadExternalReference(out Guid guid);

		public abstract bool ReadExternalReference(out string id);

		public abstract bool ReadChar(out char value);

		public abstract bool ReadString(out string value);

		public abstract bool ReadGuid(out Guid value);

		public abstract bool ReadSByte(out sbyte value);

		public abstract bool ReadInt16(out short value);

		public abstract bool ReadInt32(out int value);

		public abstract bool ReadInt64(out long value);

		public abstract bool ReadByte(out byte value);

		public abstract bool ReadUInt16(out ushort value);

		public abstract bool ReadUInt32(out uint value);

		public abstract bool ReadUInt64(out ulong value);

		public abstract bool ReadDecimal(out decimal value);

		public abstract bool ReadSingle(out float value);

		public abstract bool ReadDouble(out double value);

		public abstract bool ReadBoolean(out bool value);

		public abstract bool ReadNull();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SkipEntry()
		{
			throw null;
		}

		public abstract void Dispose();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PrepareNewSerializationSession()
		{
			throw null;
		}

		public abstract string GetDataDump();

		protected abstract EntryType PeekEntry();

		protected abstract EntryType ReadToNextEntry();
	}
}
