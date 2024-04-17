using UnityEngine;

namespace pworld.Scripts
{
	public interface PAffectable
	{
		void AddForce(Vector3 force);

		bool TakeDamage(float damage, GameObject dmgDoer);
	}
}
