using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	public class NetworkCredential
	{
		private string _domain;

		private static readonly string[] _noRoles;

		private string _password;

		private string[] _roles;

		private string _username;

		public string Domain
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

		public string Password
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

		public string[] Roles
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

		public string Username
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
		static NetworkCredential()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NetworkCredential(string username, string password)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NetworkCredential(string username, string password, string domain, params string[] roles)
		{

		}
	}
}
