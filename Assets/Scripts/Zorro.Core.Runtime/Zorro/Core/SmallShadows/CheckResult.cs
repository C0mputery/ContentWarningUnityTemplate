using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace Zorro.Core.SmallShadows
{
	internal struct CheckResult
	{
		[FormerlySerializedAs("State")]
		public bool CastShadow;

		public int Index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CheckResult(bool castShadow, int index)
		{
			throw null;
		}
	}
}
