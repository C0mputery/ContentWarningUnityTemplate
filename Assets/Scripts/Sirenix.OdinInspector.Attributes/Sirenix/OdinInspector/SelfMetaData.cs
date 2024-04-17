using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public class SelfMetaData : List<SelfValidationResult.ResultItemMetaData>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(string key, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelfMetaData()
		{
			throw null;
		}
	}
}
