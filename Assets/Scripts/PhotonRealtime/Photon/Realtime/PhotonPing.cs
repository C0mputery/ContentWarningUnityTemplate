using System;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public abstract class PhotonPing : IDisposable
	{
		public string DebugString;

		public bool Successful;

		protected internal bool GotResult;

		protected internal int PingLength;

		protected internal byte[] PingBytes;

		protected internal byte PingId;

		private static readonly Random RandomIdProvider;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool StartPing(string ip)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Done()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PhotonPing()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PhotonPing()
		{
			throw null;
		}
	}
}
