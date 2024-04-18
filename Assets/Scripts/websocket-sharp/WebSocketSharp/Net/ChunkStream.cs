using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebSocketSharp.Net
{
	internal class ChunkStream
	{
		private int _chunkRead;

		private int _chunkSize;

		private List<Chunk> _chunks;

		private int _count;

		private byte[] _endBuffer;

		private bool _gotIt;

		private WebHeaderCollection _headers;

		private int _offset;

		private StringBuilder _saved;

		private bool _sawCr;

		private InputChunkState _state;

		private int _trailerState;

		internal int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal byte[] EndBuffer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal int Offset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public WebHeaderCollection Headers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool WantsMore
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChunkStream(WebHeaderCollection headers)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private InputChunkState seekCrLf(byte[] buffer, ref int offset, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private InputChunkState setChunkSize(byte[] buffer, ref int offset, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private InputChunkState setTrailer(byte[] buffer, ref int offset, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void throwProtocolViolation(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void write(byte[] buffer, int offset, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private InputChunkState writeData(byte[] buffer, ref int offset, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ResetChunkStore()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}
	}
}
