using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class P : MonoBehaviour
	{
		public static P me;

		public Camera cam;

		public float DONTUSEME;

		public static Camera Cam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
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
		public P()
		{

		}
	}
}
