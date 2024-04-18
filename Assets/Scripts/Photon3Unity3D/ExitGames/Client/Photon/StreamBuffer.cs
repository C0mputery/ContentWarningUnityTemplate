using System.IO;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class StreamBuffer
	{
		private const int DefaultInitialSize = 0;

		private int pos;

		private int len;

		private byte[] buf;

		public bool CanRead
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool CanSeek
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool CanWrite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Length
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Position
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

		public int Available
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StreamBuffer(int size = 0)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StreamBuffer(byte[] buf)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ToArray()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ToArrayFromPos()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Compact()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] GetBuffer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] GetBufferAndAdvance(int length, out int offset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Flush()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLength(long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCapacityMinimum(int neededSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int Read(byte[] buffer, int dstOffset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(byte[] buffer, int srcOffset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte ReadByte()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteByte(byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteBytes(byte v0, byte v1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteBytes(byte v0, byte v1, byte v2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteBytes(byte v0, byte v1, byte v2, byte v3)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteBytes(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckSize(int size)
		{
			throw null;
		}
	}
}
