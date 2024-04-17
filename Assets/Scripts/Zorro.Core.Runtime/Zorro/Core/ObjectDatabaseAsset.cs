using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core.CLI;

namespace Zorro.Core
{
	public abstract class ObjectDatabaseAsset<T, ObjectT> : DatabaseAsset<T, ObjectT> where T : DatabaseAsset<T, ObjectT> where ObjectT : Object
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ObjectT GetObjectFromString(string inString)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string[] GetAllObjectNames()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<ParameterAutocomplete> GetAutocompleteOptions(string parameterText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ObjectDatabaseAsset()
		{
			throw null;
		}
	}
}
