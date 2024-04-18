using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	public class SearchableAttribute : Attribute
	{
		public bool FuzzySearch;

		public SearchFilterOptions FilterOptions;

		public bool Recursive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SearchableAttribute()
		{

		}
	}
}
