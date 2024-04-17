using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace WebSocketSharp.Net
{
	internal sealed class HttpConnection
	{
		private int _attempts;

		private byte[] _buffer;

		private static readonly int _bufferLength;

		private HttpListenerContext _context;

		private StringBuilder _currentLine;

		private InputState _inputState;

		private RequestStream _inputStream;

		private LineState _lineState;

		private EndPointListener _listener;

		private EndPoint _localEndPoint;

		private static readonly int _maxInputLength;

		private ResponseStream _outputStream;

		private int _position;

		private EndPoint _remoteEndPoint;

		private MemoryStream _requestBuffer;

		private int _reuses;

		private bool _secure;

		private Socket _socket;

		private Stream _stream;

		private object _sync;

		private int _timeout;

		private Dictionary<int, bool> _timeoutCanceled;

		private Timer _timer;

		public bool IsClosed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsLocal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsSecure
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IPEndPoint LocalEndPoint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IPEndPoint RemoteEndPoint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Reuses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Stream Stream
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HttpConnection()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HttpConnection(Socket socket, EndPointListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void closeSocket()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MemoryStream createRequestBuffer(RequestStream inputStream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void disposeRequestBuffer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void disposeStream()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void disposeTimer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void init(MemoryStream requestBuffer, int timeout)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void onRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void onTimeout(object state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processInput(byte[] data, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processRequestBuffer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string readLineFrom(byte[] buffer, int offset, int length, out int nread)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private MemoryStream takeOverRequestBuffer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void BeginReadRequest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Close(bool force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestStream GetRequestStream(long contentLength, bool chunked)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResponseStream GetResponseStream()
		{
			throw null;
		}
	}
}
