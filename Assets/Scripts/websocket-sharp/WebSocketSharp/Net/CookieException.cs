using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace WebSocketSharp.Net
{
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CookieException(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CookieException(string message, Exception innerException)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CookieException()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
