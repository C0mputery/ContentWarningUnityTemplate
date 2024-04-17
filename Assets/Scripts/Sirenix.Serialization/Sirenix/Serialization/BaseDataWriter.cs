using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class BaseDataWriter : BaseDataReaderWriter, IDataWriter, IDisposable
	{
		private SerializationContext context;

		private Stream stream;

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

		public SerializationContext Context
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
		protected BaseDataWriter(Stream stream, SerializationContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FlushToStream()
		{
			throw null;
		}

		public abstract void BeginReferenceNode(string name, Type type, int id);

		public abstract void BeginStructNode(string name, Type type);

		public abstract void EndNode(string name);

		public abstract void BeginArrayNode(long length);

		public abstract void EndArrayNode();

		public abstract void WritePrimitiveArray<T>(T[] array) where T : struct;

		public abstract void WriteNull(string name);

		public abstract void WriteInternalReference(string name, int id);

		public abstract void WriteExternalReference(string name, int index);

		public abstract void WriteExternalReference(string name, Guid guid);

		public abstract void WriteExternalReference(string name, string id);

		public abstract void WriteChar(string name, char value);

		public abstract void WriteString(string name, string value);

		public abstract void WriteGuid(string name, Guid value);

		public abstract void WriteSByte(string name, sbyte value);

		public abstract void WriteInt16(string name, short value);

		public abstract void WriteInt32(string name, int value);

		public abstract void WriteInt64(string name, long value);

		public abstract void WriteByte(string name, byte value);

		public abstract void WriteUInt16(string name, ushort value);

		public abstract void WriteUInt32(string name, uint value);

		public abstract void WriteUInt64(string name, ulong value);

		public abstract void WriteDecimal(string name, decimal value);

		public abstract void WriteSingle(string name, float value);

		public abstract void WriteDouble(string name, double value);

		public abstract void WriteBoolean(string name, bool value);

		public abstract void Dispose();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PrepareNewSerializationSession()
		{
			throw null;
		}

		public abstract string GetDataDump();
	}
}
