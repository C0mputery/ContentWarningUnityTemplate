using System;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	public class MessageEventArgs : EventArgs
	{
		private string _data;

		private bool _dataSet;

		private Opcode _opcode;

		private byte[] _rawData;

		internal Opcode Opcode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Data
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

		public bool IsPing
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

		public byte[] RawData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MessageEventArgs(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MessageEventArgs(Opcode opcode, byte[] rawData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setData()
		{
			throw null;
		}
	}
}
