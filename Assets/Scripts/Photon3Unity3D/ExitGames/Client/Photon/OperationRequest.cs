using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class OperationRequest
	{
		public byte OperationCode;

		public ParameterDictionary Parameters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OperationRequest()
		{

		}
	}
}
