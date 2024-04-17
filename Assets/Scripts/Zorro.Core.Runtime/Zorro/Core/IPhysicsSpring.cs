using UnityEngine;

namespace Zorro.Core
{
	public interface IPhysicsSpring
	{
		[SerializeField]
		float Spring { get; set; }

		[SerializeField]
		float Drag { get; set; }

		void FixedUpdate();

		void Update();
	}
}
