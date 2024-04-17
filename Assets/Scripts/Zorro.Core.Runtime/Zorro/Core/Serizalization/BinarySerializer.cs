using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Collections;
using Unity.Mathematics;

namespace Zorro.Core.Serizalization
{
	public class BinarySerializer : IDisposable
	{
		private NativeList<byte> m_buffer;

		public int Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public NativeArray<byte> buffer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinarySerializer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinarySerializer(int defaultCapacity, Allocator allocator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteByte(byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteBytes(NativeArray<byte> value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteFloat(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteFloat2(float2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteFloat3(float3 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteFloat4(float4 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteHalf(half value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteInt(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteInt2(int2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteInt3(int3 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteInt4(int4 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteUInt(uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteUInt2(uint2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteUInt3(uint3 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteUInt4(uint4 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteBool(bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteUlong(ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteLong(long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteUshort(ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteOptionableLong(Optionable<long> value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteGuid(Guid guid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteString(string comment, Encoding encoding)
		{
			throw null;
		}
	}
}
