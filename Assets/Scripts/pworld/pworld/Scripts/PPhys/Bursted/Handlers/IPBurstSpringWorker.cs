using UnityEngine;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public interface IPBurstSpringWorker<TTarget, TSpringData> where TTarget : struct where TSpringData : struct
	{
		TSpringData Data { get; protected set; }

		Transform Transform { get; }

		TTarget Target { get; }

		Vector3 Velocity { get; set; }

		void Hire(int _index);

		void Fire();
	}
}
