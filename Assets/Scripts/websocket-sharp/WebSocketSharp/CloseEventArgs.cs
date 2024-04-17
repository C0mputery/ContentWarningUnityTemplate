using System;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	public class CloseEventArgs : EventArgs
	{
		private bool _clean;

		private PayloadData _payloadData;

		public ushort Code
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool WasClean
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CloseEventArgs(PayloadData payloadData, bool clean)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CloseEventArgs(ushort code, string reason, bool clean)
		{
			throw null;
		}
	}
}
