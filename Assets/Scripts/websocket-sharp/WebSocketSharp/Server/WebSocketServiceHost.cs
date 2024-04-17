using System;
using System.Runtime.CompilerServices;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public abstract class WebSocketServiceHost
	{
		private Logger _log;

		private string _path;

		private WebSocketSessionManager _sessions;

		internal ServerState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected Logger Log
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

		public string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public WebSocketSessionManager Sessions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public abstract Type BehaviorType { get; }

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
		protected WebSocketServiceHost(string path, Logger log)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void StartSession(WebSocketContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Stop(ushort code, string reason)
		{
			throw null;
		}

		protected abstract WebSocketBehavior CreateSession();
	}
	internal class WebSocketServiceHost<TBehavior> : WebSocketServiceHost where TBehavior : WebSocketBehavior, new()
	{
		private Func<TBehavior> _creator;

		public override Type BehaviorType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketServiceHost(string path, Action<TBehavior> initializer, Logger log) : base(path, log)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<TBehavior> createSessionCreator(Action<TBehavior> initializer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override WebSocketBehavior CreateSession()
		{
			throw null;
		}
	}
}
