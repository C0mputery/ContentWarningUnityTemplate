using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	internal class WebSocketFrame : IEnumerable<byte>, IEnumerable
	{
		private byte[] _extPayloadLength;

		private Fin _fin;

		private Mask _mask;

		private byte[] _maskingKey;

		private Opcode _opcode;

		private PayloadData _payloadData;

		private byte _payloadLength;

		private Rsv _rsv1;

		private Rsv _rsv2;

		private Rsv _rsv3;

		internal ulong ExactPayloadLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal int ExtendedPayloadLengthWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte[] ExtendedPayloadLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Fin Fin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsBinary
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsClose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsCompressed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsContinuation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsControl
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsFinal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsFragment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsMasked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsPing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsPong
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public ulong Length
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Mask Mask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte[] MaskingKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Opcode Opcode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public PayloadData PayloadData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte PayloadLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Rsv Rsv1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Rsv Rsv2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Rsv Rsv3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private WebSocketFrame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketFrame(Opcode opcode, PayloadData payloadData, bool mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketFrame(Fin fin, Opcode opcode, byte[] data, bool compressed, bool mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketFrame(Fin fin, Opcode opcode, PayloadData payloadData, bool compressed, bool mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] createMaskingKey()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string dump(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string print(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WebSocketFrame processHeader(byte[] header)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WebSocketFrame readExtendedPayloadLength(Stream stream, WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void readExtendedPayloadLengthAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WebSocketFrame readHeader(Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void readHeaderAsync(Stream stream, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WebSocketFrame readMaskingKey(Stream stream, WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void readMaskingKeyAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WebSocketFrame readPayloadData(Stream stream, WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void readPayloadDataAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string utf8Decode(byte[] bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WebSocketFrame CreateCloseFrame(PayloadData payloadData, bool mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WebSocketFrame CreatePingFrame(bool mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WebSocketFrame CreatePingFrame(byte[] data, bool mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WebSocketFrame CreatePongFrame(PayloadData payloadData, bool mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WebSocketFrame ReadFrame(Stream stream, bool unmask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ReadFrameAsync(Stream stream, bool unmask, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Unmask()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<byte> GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Print(bool dumped)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string PrintToString(bool dumped)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ToArray()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
