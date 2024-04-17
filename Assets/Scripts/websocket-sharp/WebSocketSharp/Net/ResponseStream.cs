using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	internal class ResponseStream : Stream
	{
		private MemoryStream _bodyBuffer;

		private static readonly byte[] _crlf;

		private bool _disposed;

		private Stream _innerStream;

		private static readonly byte[] _lastChunk;

		private static readonly int _maxHeadersLength;

		private HttpListenerResponse _response;

		private bool _sendChunked;

		private Action<byte[], int, int> _write;

		private Action<byte[], int, int> _writeBody;

		private Action<byte[], int, int> _writeChunked;

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
		static ResponseStream()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ResponseStream(Stream innerStream, HttpListenerResponse response, bool ignoreWriteExceptions)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool flush(bool closing)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void flushBody(bool closing)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool flushHeaders()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] getChunkSizeBytes(int size)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void writeChunked(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void writeChunkedWithoutThrowingException(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void writeWithoutThrowingException(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Close(bool force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWrite(byte[] buffer, int offset, int count)
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
		protected override void Dispose(bool disposing)
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
