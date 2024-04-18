using System;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	[Serializable]
	public sealed class Cookie
	{
		private string _comment;

		private Uri _commentUri;

		private bool _discard;

		private string _domain;

		private static readonly int[] _emptyPorts;

		private DateTime _expires;

		private bool _httpOnly;

		private string _name;

		private string _path;

		private string _port;

		private int[] _ports;

		private static readonly char[] _reservedCharsForValue;

		private string _sameSite;

		private bool _secure;

		private DateTime _timeStamp;

		private string _value;

		private int _version;

		internal bool ExactDomain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal int MaxAge
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

		internal int[] Ports
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal string SameSite
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

		public string Comment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public Uri CommentUri
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public bool Discard
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public string Domain
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

		public bool Expired
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

		public DateTime Expires
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

		public bool HttpOnly
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

		public string Name
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public string Port
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public bool Secure
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

		public DateTime TimeStamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Value
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

		public int Version
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Cookie()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Cookie()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Cookie(string name, string value)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Cookie(string name, string value, string path)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Cookie(string name, string value, string path, string domain)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int hash(int i, int j, int k, int l, int m)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void init(string name, string value, string path, string domain)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string toResponseStringVersion0()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string toResponseStringVersion1()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool tryCreatePorts(string value, out int[] result)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool EqualsWithoutValue(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool EqualsWithoutValueAndVersion(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string ToRequestString(Uri uri)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string ToResponseString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryCreate(string name, string value, out Cookie result)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
