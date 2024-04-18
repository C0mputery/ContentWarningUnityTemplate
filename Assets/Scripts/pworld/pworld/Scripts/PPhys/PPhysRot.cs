using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys
{
	public class PPhysRot : MonoBehaviour
	{
		public enum SPACE
		{
			World = 0,
			Parent = 1,
			Start = 2
		}

		public float rotSpring;

		public float rotDamp;

		public float fakeMass;

		public bool lockX;

		public bool lockY;

		public bool lockZ;

		public Vector3 angularVel;

		public Transform TarTrans;

		public SPACE space;

		private Vector3 localStartDir;

		private Vector3 localStartUp;

		public Vector3 TarPos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Vector3 TarUp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

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
		public void AddForce(Vector3 force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 ConstrainVector(Vector3 direction, Transform baseTransform)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PPhysRot()
		{

		}
	}
}
