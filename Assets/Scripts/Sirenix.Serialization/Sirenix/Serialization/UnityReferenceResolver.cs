using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.Serialization.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class UnityReferenceResolver : IExternalIndexReferenceResolver, ICacheNotificationReceiver
	{
		private Dictionary<Object, int> referenceIndexMapping;

		private List<Object> referencedUnityObjects;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnityReferenceResolver()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnityReferenceResolver(List<Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Object> GetReferencedUnityObjects()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetReferencedUnityObjects(List<Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanReference(object value, out int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryResolveReference(int index, out object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICacheNotificationReceiver.OnFreed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICacheNotificationReceiver.OnClaimed()
		{
			throw null;
		}
	}
}
