using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	internal class ChunkedRequestStream : RequestStream
	{
		private static readonly int _bufferLength;

		private HttpListenerContext _context;

		private ChunkStream _decoder;

		private bool _disposed;

		private bool _noMoreData;

		internal bool HasRemainingBuffer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal byte[] RemainingBuffer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChunkedRequestStream()
		{
			throw null;
		}

        internal ChunkedRequestStream(Stream innerStream, byte[] initialBuffer, int offset, int count, long contentLength) : base(innerStream, initialBuffer, offset, count, contentLength)
        {
            throw null;
        }

        /*[MethodImpl(MethodImplOptions.NoInlining)]
		internal ChunkedRequestStream(Stream innerStream, byte[] initialBuffer, int offset, int count, HttpListenerContext context)
		{
        }*/

        [MethodImpl(MethodImplOptions.NoInlining)]
		private void onRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
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
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}
	}
}
