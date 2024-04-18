using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline.Demo
{
	public class CameraController : MonoBehaviour
	{
		[SerializeField]
		private Vector3 shift;

		[SerializeField]
		private float moveSpeed;

		[SerializeField]
		private Transform target;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CameraController()
		{

		}
	}
}
