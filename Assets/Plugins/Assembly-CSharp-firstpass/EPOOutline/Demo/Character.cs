using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace EPOOutline.Demo
{
	public class Character : MonoBehaviour
	{
		[SerializeField]
		private AudioSource walkSource;

		[SerializeField]
		private NavMeshAgent agent;

		[SerializeField]
		private Animator characterAnimator;

		private float initialWalkVolume;

		private Camera mainCamera;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTriggerEnter(Collider other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Character()
		{
			throw null;
		}
	}
}
