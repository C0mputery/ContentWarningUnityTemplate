using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class PrefabModification
	{
		public PrefabModificationType ModificationType;

		public string Path;

		public List<string> ReferencePaths;

		public object ModifiedValue;

		public int NewLength;

		public object[] DictionaryKeysAdded;

		public object[] DictionaryKeysRemoved;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply(Object unityObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ApplyValue(Object unityObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ApplyListLength(Object unityObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ApplyDictionaryModifications(Object unityObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ReplaceAllReferencesInGraph(object graph, object oldReference, object newReference, HashSet<object> processedReferences = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object GetInstanceFromPath(string path, object instance)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object GetInstanceOfStep(string step, object instance)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SetInstanceToPath(string path, object instance, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SetInstanceToPath(string path, string[] steps, int index, object instance, object value, out bool setParentInstance)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool TrySetInstanceOfStep(string step, object instance, object value, out bool setParentInstance)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrefabModification()
		{

		}
	}
}
