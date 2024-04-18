using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public class DefaultPool : IPunPrefabPool
	{
		public readonly Dictionary<string, GameObject> ResourceCache;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameObject Instantiate(string prefabId, Vector3 position, Quaternion rotation)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Destroy(GameObject gameObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DefaultPool()
		{

		}
	}
}
