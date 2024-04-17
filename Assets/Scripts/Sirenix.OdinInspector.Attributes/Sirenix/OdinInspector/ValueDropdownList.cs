using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public class ValueDropdownList<T> : List<ValueDropdownItem<T>>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(string text, T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueDropdownList()
		{
			throw null;
		}
	}
}
