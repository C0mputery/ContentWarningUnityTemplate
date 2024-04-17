using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Collections;
using Unity.Mathematics;

namespace Zorro.Core.Serizalization
{
	public class BinaryDeserializer : IDisposable
	{
		public NativeArray<byte> buffer;

		public int position;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinaryDeserializer(NativeArray<byte> buffer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinaryDeserializer(byte[] buffer, Allocator allocator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinaryDeserializer(BinarySerializer serializer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte ReadByte()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ReadFloat()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float2 ReadFloat2()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float3 ReadFloat3()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float4 ReadFloat4()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public half ReadHalf()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ReadInt()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int2 ReadInt2()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int3 ReadInt3()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int4 ReadInt4()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public uint ReadUInt()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public uint2 ReadUInt2()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public uint3 ReadUInt3()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public uint4 ReadUInt4()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ReadBool()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ulong ReadUlong()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public long ReadLong()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ushort ReadUShort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NativeArray<byte> ReadBytes(int count, Allocator allocator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Guid ReadGuid()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ReadString(Encoding encoding)
		{
			throw null;
		}
	}
}
