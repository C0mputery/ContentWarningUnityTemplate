using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Timers;

namespace WebSocketSharp.Server
{
	public class WebSocketSessionManager
	{
		private static readonly byte[] _emptyPingFrameAsBytes;

		private object _forSweep;

		private volatile bool _keepClean;

		private Logger _log;

		private Dictionary<string, IWebSocketSession> _sessions;

		private volatile ServerState _state;

		private volatile bool _sweeping;

		private Timer _sweepTimer;

		private object _sync;

		private TimeSpan _waitTime;

		internal ServerState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IEnumerable<string> ActiveIDs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IEnumerable<string> IDs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IEnumerable<string> InactiveIDs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IWebSocketSession this[string id]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool KeepClean
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

		public IEnumerable<IWebSocketSession> Sessions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public TimeSpan WaitTime
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
		static WebSocketSessionManager()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketSessionManager(Logger log)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void broadcast(Opcode opcode, byte[] data, Action completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void broadcast(Opcode opcode, Stream stream, Action completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void broadcastAsync(Opcode opcode, byte[] data, Action completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void broadcastAsync(Opcode opcode, Stream stream, Action completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Dictionary<string, bool> broadping(byte[] frameAsBytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool canSet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string createID()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setSweepTimer(double interval)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void stop(PayloadData payloadData, bool send)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool tryGetSession(string id, out IWebSocketSession session)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string Add(IWebSocketSession session)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool Remove(string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Stop(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Broadcast(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Broadcast(string data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Broadcast(Stream stream, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BroadcastAsync(byte[] data, Action completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BroadcastAsync(string data, Action completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BroadcastAsync(Stream stream, int length, Action completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseSession(string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseSession(string id, ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseSession(string id, CloseStatusCode code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PingTo(string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PingTo(string message, string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTo(byte[] data, string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTo(string data, string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTo(Stream stream, int length, string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendToAsync(byte[] data, string id, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendToAsync(string data, string id, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendToAsync(Stream stream, int length, string id, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Sweep()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetSession(string id, out IWebSocketSession session)
		{
			throw null;
		}
	}
}
