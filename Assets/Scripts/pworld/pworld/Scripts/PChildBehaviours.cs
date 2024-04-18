using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PChildBehaviours : MonoBehaviour
	{
		public enum CHILD_TYPE
		{
			Step = 0
		}

		public CHILD_TYPE childType;

		public Transform parent;

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
		private void StepUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PChildBehaviours()
		{

		}
	}
}
