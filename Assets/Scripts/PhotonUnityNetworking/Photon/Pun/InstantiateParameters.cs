using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Pun
{
	public struct InstantiateParameters
	{
		public int[] viewIDs;

		public byte objLevelPrefix;

		public object[] data;

		public byte group;

		public Quaternion rotation;

		public Vector3 position;

		public string prefabName;

		public Player creator;

		public int timestamp;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, Player creator, int timestamp)
		{
			throw null;
		}
	}
}
