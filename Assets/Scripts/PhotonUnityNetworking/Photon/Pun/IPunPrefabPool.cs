using UnityEngine;

namespace Photon.Pun
{
	public interface IPunPrefabPool
	{
		GameObject Instantiate(string prefabId, Vector3 position, Quaternion rotation);

		void Destroy(GameObject gameObject);
	}
}
