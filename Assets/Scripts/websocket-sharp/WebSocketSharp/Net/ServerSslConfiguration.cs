using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketSharp.Net
{
	public class ServerSslConfiguration
	{
		private bool _checkCertRevocation;

		private bool _clientCertRequired;

		private RemoteCertificateValidationCallback _clientCertValidationCallback;

		private SslProtocols _enabledSslProtocols;

		private X509Certificate2 _serverCert;

		public bool CheckCertificateRevocation
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

		public bool ClientCertificateRequired
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

		public RemoteCertificateValidationCallback ClientCertificateValidationCallback
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

		public SslProtocols EnabledSslProtocols
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

		public X509Certificate2 ServerCertificate
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
		public ServerSslConfiguration()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSslConfiguration(ServerSslConfiguration configuration)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool defaultValidateClientCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			throw null;
		}
	}
}
