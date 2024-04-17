using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	internal class RequestStream : Stream
	{
		private long _bodyLeft;

		private int _count;

		private bool _disposed;

		private byte[] _initialBuffer;

		private Stream _innerStream;

		private int _offset;

		internal int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal byte[] InitialBuffer
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

		public override bool CanRead
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool CanSeek
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool CanWrite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override long Length
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override long Position
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
		internal RequestStream(Stream innerStream, byte[] initialBuffer, int offset, int count, long contentLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int fillFromInitialBuffer(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Flush()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLength(long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}
	}
}
