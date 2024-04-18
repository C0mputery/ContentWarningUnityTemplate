using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public class OdinDefineSymbols
	{
		public const bool SIRENIX_INTERNAL = false;

		public const bool ODIN_ASSET_STORE = false;

		public const bool ODIN_TRIAL = false;

		public const bool ODIN_EDUCATIONAL = false;

		public const bool ODIN_GAMEJAM = false;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OdinDefineSymbols()
		{

		}
	}
}
