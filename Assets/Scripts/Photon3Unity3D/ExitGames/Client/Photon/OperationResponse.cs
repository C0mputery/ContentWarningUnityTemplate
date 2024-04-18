using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class OperationResponse
	{
		public byte OperationCode;

		public short ReturnCode;

		public string DebugMessage;

		public ParameterDictionary Parameters;

		public object this[byte parameterCode]
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
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToStringFull()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OperationResponse()
		{

		}
	}
}
