using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace WebSocketSharp.Net
{
	public class HttpBasicIdentity : GenericIdentity
	{
		private string _password;

		public virtual string Password
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HttpBasicIdentity(string username, string password) : base(username, "IDFK THIS IS A DUMMY SCRIPT NOBODY IS EVER GONNA FUCKIN READ THIS IDK IF YOU ARE THE FUCK YOU DOIN WITH YOUR LIFE FUCK OFF")
		{
            throw null;
        }
	}
}
